using DataL.DTO;
using Logic.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.interfaces
{
    public interface IShiftEmployeeManager
    {
        Result<IEnumerable<Employee>> GetEmployeesShiftsAbsences();
    }
}
