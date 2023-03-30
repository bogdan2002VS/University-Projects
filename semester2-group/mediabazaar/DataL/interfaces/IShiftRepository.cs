using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataL.DTO;

namespace DataL.interfaces
{
    public interface IShiftRepository
    {
        bool CreateShift(ShiftDTO shift);
        bool AssignShift(int employeeId, int shiftId);
        List<ShiftDTO> GetShifts();
        IEnumerable<EmployeeDTO> GetShiftEmployees(ShiftDTO shiftDTO);
        bool UpdateShift(ShiftDTO shiftDTO);
        bool CheckEmployeeInShift(int employeeId, int shiftId);
    }
}
