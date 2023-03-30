using DataL;
using DataL.DTO;
using DataL.interfaces;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Logic.Pool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ClassManagers
{
    public class ShiftManager : IShiftManager
    {
        private readonly IShiftEmployeeManager employeeManager;
        private readonly IShiftRepository shiftRepository;

        //events-delegate
        public delegate void ShiftDelegate(bool value);
        public event ShiftDelegate ShiftHandler;
        public ShiftManager(IShiftRepository shiftRepository, IShiftEmployeeManager employeeManager)
        {
            this.shiftRepository = shiftRepository;
            this.employeeManager = employeeManager;
        }

        public Result<bool> AutomaticShift(Shift shift)
        {
            if (shift.IsFull)
            {
                return Result<bool>.Fail(new ArgumentException("This Shift is Full"));
            }

            List<Employee> employees = employeeManager.GetEmployeesShiftsAbsences().Value.ToList() ?? new List<Employee>();

            List<Employee> firstFilter = new List<Employee>();
            foreach (Employee e in CollectionsMarshal.AsSpan(employees))
            {
                if (e.Absences.Count != 0)
                {
                    int count = 0;
                    foreach (Absence a in e.Absences)
                    {
                        if (shift.Start.Day > a.Date.Day && shift.End.Day > a.Date.Day)
                        {
                            count++;
                        }

                        if (count == e.Absences.Count)
                        {
                            firstFilter.Add(e);
                            count = 0;
                        }
                    }
                }
                else
                {
                    firstFilter.Add(e);
                }
            }

            List<Employee> secondFilter = new List<Employee>();
            foreach (Employee e in CollectionsMarshal.AsSpan(firstFilter))
            {
                if (e.Shifts.Count != 0)
                {
                    int count = 0;
                    foreach (Shift s in e.Shifts)
                    {
                        if (shift.Start > s.Start && shift.Start > s.End)
                        {
                            count++;
                        }

                        if (count == e.Shifts.Count)
                        {
                            secondFilter.Add(e);
                            count = 0;
                        }
                    }
                }
                else
                {
                    secondFilter.Add(e);
                }
            }

            List<Employee> shiftEmployees = new List<Employee>();

            int countCashier = 0;
            int countSecurity = 0;
            int countStockManager = 0;
            int countDepoManager = 0;
            int countEmployeeManager = 0;
            int countHR = 0;
            foreach (Employee e in CollectionsMarshal.AsSpan(secondFilter))
            {
                if (e.GetType() == typeof(Cashier))
                {
                    if (countCashier < shift.MaxCashier)
                    {
                        shiftEmployees.Add((Cashier)e);
                        countCashier++;
                    }
                }
                else if (e.GetType() == typeof(Security))
                {
                    if (countSecurity < shift.MaxSecurity)
                    {
                        shiftEmployees.Add((Security)e);
                        countSecurity++;
                    }
                }
                else if (e.GetType() == typeof(StockManager))
                {
                    if (countStockManager < shift.MaxStockManager)
                    {
                        shiftEmployees.Add((StockManager)e);
                        countStockManager++;
                    }
                }
                else if (e.GetType() == typeof(DepoManager))
                {
                    if (countDepoManager < shift.MaxDepoManager)
                    {
                        shiftEmployees.Add((DepoManager)e);
                        countDepoManager++;
                    }
                }
                else if (e.GetType() == typeof(ManagerEmployees))
                {
                    if (countEmployeeManager < shift.MaxEmployeeManager)
                    {
                        shiftEmployees.Add((ManagerEmployees)e);
                        countEmployeeManager++;
                    }
                }
                else if (e.GetType() == typeof(HR))
                {
                    if (countHR < shift.MaxHR)
                    {
                        shiftEmployees.Add((HR)e);
                        countHR++;
                    }
                }
            }

            if (shift.MaxCashier > countCashier)
            {
                return Result<bool>.Fail(new ArgumentException("There are not enough Cashier staff for this shift"));
            }
            else if (shift.MaxSecurity > countSecurity)
            {
                return Result<bool>.Fail(new ArgumentException("There are not enough Security staff for this shift"));
            }
            else if (shift.MaxStockManager > countStockManager)
            {
                return Result<bool>.Fail(new ArgumentException("There are not enough Stock Manager staff for this shift"));
            }
            else if (shift.MaxDepoManager > countDepoManager)
            {
                return Result<bool>.Fail(new ArgumentException("There are not enough Department Manager staff for this shift"));
            }
            else if (shift.MaxEmployeeManager > countEmployeeManager)
            {
                return Result<bool>.Fail(new ArgumentException("There are not enough Employee Manager staff for this shift"));
            }
            else if (shift.MaxHR > countHR)
            {
                return Result<bool>.Fail(new ArgumentException("There are not enough HR staff for this shift"));
            }

            foreach (Employee e in shiftEmployees)
            {
                AssignShift(e.Id, shift);
            }

            shift.IsFull = true;

            bool success = UpdateShift(shift).Success;
            ShiftHandler(success);

            return Result<bool>.Ok(success);
        }

        public Result<bool> CreateShift(Shift shift)
        {
            if (shift.End < shift.Start)
            {
                return Result<bool>.Fail(new ArgumentException("The shift Ending cannot be before the Start"));
            }

            ShiftDTO shiftDTO = ConverterPool.GetConverter<Shift, ShiftDTO>().Convert(shift);

            bool success = shiftRepository.CreateShift(shiftDTO);

            if (!success)
            {
                return Result<bool>.Ok(success);
            }

            ShiftHandler(success);

            return Result<bool>.Ok(success);
        }

        public Result<Shift[]> GetShifts()
        {
            List<ShiftDTO> shiftsDTO = shiftRepository.GetShifts();

            Shift[] shifts = ConverterPool.GetConverter<Shift, ShiftDTO>().Convert(shiftsDTO);

            return Result<Shift[]>.Ok(shifts);
        }

        public Result<bool> AssignShift(int employeeId, Shift shift)
        {
            if (shift.IsFull)
            {
                return Result<bool>.Fail(new ArgumentException("This is Shift is Already Full"));
            }

            if (CheckEmployeeInShift(employeeId, shift.Id))
            {
                return Result<bool>.Fail(new ArgumentException("This Employee is already in this shift"));
            }

            bool success = shiftRepository.AssignShift(employeeId, shift.Id);

            if (!success)
            {
                return Result<bool>.Fail(new ArgumentException($"There was a problem assigning shift to Employee: {employeeId}"));
            }

            return Result<bool>.Ok(success);
        }

        public Result<IEnumerable<Employee>> GetShiftEmployees(Shift shift)
        {
            ShiftDTO shiftDTO = ConverterPool.GetConverter<Shift, ShiftDTO>().Convert(shift);

            List<EmployeeDTO> employeesDTO = shiftRepository.GetShiftEmployees(shiftDTO).ToList();
            Employee[] employees = ConverterPool.GetConverter<Employee, EmployeeDTO>().Convert(employeesDTO);

            return Result<IEnumerable<Employee>>.Ok(employees);
        }

        public Result<bool> UpdateShift(Shift shift)
        {
            ShiftDTO shiftDTO = ConverterPool.GetConverter<Shift, ShiftDTO>().Convert(shift);

            bool result = shiftRepository.UpdateShift(shiftDTO);
            return Result<bool>.Ok(result);
        }

        public bool CheckEmployeeInShift(int employeeId, int shiftId)
        {
            bool employeeIsInShift = shiftRepository.CheckEmployeeInShift(employeeId, shiftId);

            return employeeIsInShift;
        }
    }
}
