using DataL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.interfaces
{
    public interface IAbsenceRepository
    {
        IEnumerable<AbsenceDTO> GetAbsenceDTOs();
        bool UpdateAbsence(AbsenceDTO absence);
        bool CreateAbsence(AbsenceDTO absenceDTO);
    }
}
