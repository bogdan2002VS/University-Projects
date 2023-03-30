using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.EmployeeTypes;
using static Logic.ClassManagers.ShiftManager;

namespace Logic.interfaces
{
    public interface IShiftManager
    {
        event ShiftDelegate ShiftHandler;
        Result<bool> AutomaticShift(Shift shift);
        Result<bool> CreateShift(Shift shift);
        Result<Shift[]> GetShifts();
        Result<bool> AssignShift(int employeeId, Shift shift);
        Result<IEnumerable<Employee>> GetShiftEmployees(Shift shift);
    }
}
