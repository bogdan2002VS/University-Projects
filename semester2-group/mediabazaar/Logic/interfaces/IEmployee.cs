using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.CustomEventArgs;
using Logic.EmployeeTypes;
using static Logic.ClassManagers.EmployeeManager;

namespace Logic.interfaces
{
    public interface IEmployee
    {
        Result<Employee[]> GetEmployees();

        Result<Employee[]> GetEmployeesOverview();

        Result<Employee[]> GetEmployeesManagers();

        Result<bool> AddEmployee(Employee e);

        Result<Employee> GetEmployee(int id);

        Result<Absence[]> GetEmployeeAbsences(int id);

        Result<IEnumerable<Employee>> GetEmployeesShiftsAbsences();

        Result<Shift[]> GetEmployeeShifts(int id);

        Result<Warnings[]> GetEmployeeWarnings(int id);

        bool RemoveEmployee(int id, Type type);

        Result<bool> UpdateEmployee(Employee employee);

        List<Employee> SearchEmployee(string[] textSearch);

        bool AssignEmployeeToDepartment(int departmentId, int userId);

        //events

        event EventHandler<EmployeeArgs> EmployeeAdded;
    }
}
