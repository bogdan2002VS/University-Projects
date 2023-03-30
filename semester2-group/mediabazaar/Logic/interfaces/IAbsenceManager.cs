using Logic.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.ClassManagers.AbsenceManager;

namespace Logic.interfaces
{
    public interface IAbsenceManager
    {
        event AbsenceDelegate AbsenceHandler;
        Absence[] GetAbsences();
        bool UpdateAbsence(Absence absence);
        bool CreateAbsence(Absence absence);
    }
}
