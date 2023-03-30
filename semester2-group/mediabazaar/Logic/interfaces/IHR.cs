using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.CustomEventArgs;
using Logic.EmployeeTypes;

namespace Logic.interfaces
{
    public interface IHR
    {
        Result<bool> AddEmployee(Employee e);

        Result<Employee[]> GetEmployeesManagers();

        bool RemoveEmployee(int id, Type type);

        Result<bool> UpdateEmployee(Employee employee);

        //events
        event EventHandler<EmployeeArgs> EmployeeAdded;
    }
}
