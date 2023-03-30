using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataL.DTO;

namespace DataL.interfaces
{
    public interface IManagerRepository
    {
        EmployeeDTO GetEmployee(int id);

        List<ShiftDTO> GetEmployeeShifts(int id);

        IEnumerable<EmployeeDTO> GetEmployeesShiftsAbsences();
        List<WarningDTO> GetEmployeeWarnings(int id);

        List<AbsenceDTO> GetEmployeeAbsences(int id);

        List<EmployeeDTO> GetEmployees();

        List<EmployeeDTO> GetEmployeesOverView();

        List<EmployeeDTO> GetEmployeesManagers();

        int AddEmployee(EmployeeDTO employee);

        bool RemoveEmployee(int id, string type);

        bool UpdateEmployee(EmployeeDTO employee);

        bool AssignEmployeeToDepartment(int departmentId, int employeeId);
    }
}
