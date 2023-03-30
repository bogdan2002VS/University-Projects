using DataL.DTO;
using DataL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.MockRepository
{
    public class AbsenceManagerMockRep : IManagerRepository
    {
        List<EmployeeDTO> employeeDTOs;
        List<ShiftDTO> shiftDTOs;

        public AbsenceManagerMockRep()
        {
            employeeDTOs = new List<EmployeeDTO>();
            shiftDTOs = new List<ShiftDTO>();

            employeeDTOs.Add(new EmployeeDTO
            {
                Id = 1,
                FirstName = "teste",
                LastName = "teste",
                Email = "teste@gmail.com",
                PhoneNumber = "phonenumber",
                EmployeeType = 0
            });

            employeeDTOs.Add(new EmployeeDTO
            {
                Id = 2,
                FirstName = "teste2",
                LastName = "teste2",
                Email = "teste2@gmail.com",
                PhoneNumber = "phonenumber2",
                EmployeeType = 0
            });

            employeeDTOs.Add(new EmployeeDTO
            {
                Id = 3,
                FirstName = "teste3",
                LastName = "teste3",
                Email = "teste3@gmail.com",
                PhoneNumber = "phonenumber3",
                EmployeeType = 2
            });

            employeeDTOs.Add(new EmployeeDTO
            {
                Id = 4,
                FirstName = "teste4",
                LastName = "teste4",
                Email = "teste4@gmail.com",
                PhoneNumber = "phonenumber4",
                EmployeeType = 2
            });

            employeeDTOs.Add(new EmployeeDTO
            {
                Id = 5,
                FirstName = "teste5",
                LastName = "teste5",
                Email = "teste5@gmail.com",
                PhoneNumber = "phonenumber5",
                EmployeeType = 1
            });


            employeeDTOs.Add(new EmployeeDTO
            {
                Id = 696969,
                FirstName = "hrtest",
                LastName = "hrtest",
                Email = "hrtest@gmail.com",
                PhoneNumber = "phonenumber5",
                EmployeeType = 1
            });

            employeeDTOs.Add(new EmployeeDTO
            {
                Id = 6,
                FirstName = "teste6",
                LastName = "teste6",
                Email = "teste6@gmail.com",
                PhoneNumber = "phonenumber6",
                EmployeeType = 1
            });

            shiftDTOs.Add(new ShiftDTO
            {
                Id= 1,
                Start = DateTime.Now,
                End = DateTime.Now.AddHours(3),
                MaxSecurity = 1,
                MaxCashier = 1
            });

            shiftDTOs.Add(new ShiftDTO
            {
                Id = 2,
                Start = DateTime.Now.AddDays(1),
                End = DateTime.Now.AddDays(1).AddHours(3),
                MaxSecurity = 1,
                MaxCashier = 1
            });
        }

        public bool AddAbsence(AbsenceDTO a)
        {
            throw new NotImplementedException();
        }

        public int AddEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }

        public bool AssignEmployeeToDepartment(int departmentId, int employeeId)
        {
            throw new NotImplementedException();
        }

        public bool AssignShift(int employeeId, int shiftId)
        {
            return true; ;
        }

        public bool CheckUsername(string username)
        {
            throw new NotImplementedException();
        }

        public bool CreateShift(ShiftDTO shift)
        {
            shiftDTOs.Add(shift);

            return true;
        }

        public EmployeeDTO GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<AbsenceDTO> GetEmployeeAbsences(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDTO> GetEmployees()
        {
            return employeeDTOs;
        }

        public List<ShiftDTO> GetEmployeeShifts(int id)
        {
            return shiftDTOs;
        }

        public List<EmployeeDTO> GetEmployeesManagers()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDTO> GetEmployeesOverView()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDTO> GetEmployeesShiftsAbsences()
        {
            foreach(EmployeeDTO e in employeeDTOs)
            {
                e.ShiftDTOs = shiftDTOs;
            }

            return employeeDTOs;
        }

        public List<WarningDTO> GetEmployeeWarnings(int id)
        {
            throw new NotImplementedException();
        }

        public List<ShiftDTO> GetShifts()
        {
            throw new NotImplementedException();
        }

        public bool RemoveEmployee(int id, string type)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }

        IEnumerable<EmployeeDTO> IManagerRepository.GetEmployeesShiftsAbsences()
        {
            throw new NotImplementedException();
        }
    }
}
