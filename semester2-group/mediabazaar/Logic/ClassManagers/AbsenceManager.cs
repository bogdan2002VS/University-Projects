using DataL.DTO;
using DataL.interfaces;
using Logic.interfaces;
using Logic.Pool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.ClassManagers
{
    public class AbsenceManager : IAbsenceManager
    {
        private readonly IAbsenceRepository absenceRepository;

        //event
        public delegate void AbsenceDelegate(bool success);
        public event AbsenceDelegate AbsenceHandler;

        public AbsenceManager(IAbsenceRepository absenceRepository)
        {
            this.absenceRepository = absenceRepository;
        }
        public Absence[] GetAbsences()
        {
            List<AbsenceDTO> absencesDTO = absenceRepository.GetAbsenceDTOs().ToList();

            Absence[] absences = ConverterPool.GetConverter<Absence, AbsenceDTO>().Convert(absencesDTO);

            return absences;
        }

        public bool UpdateAbsence(Absence absence)
        {
            AbsenceDTO absenceDTO = new AbsenceDTO
            {
                Id = absence.Id,
                Date = absence.Date,
                AbsenceDescription = absence.AbsenceDescription,
                AbsenceReason = absence.AbsenceReason,
                TicketStatus = (int)absence.TicketStatus,
                Employee = new EmployeeDTO
                {
                    Id = absence.Employee.Id
                }
            };

            bool success = absenceRepository.UpdateAbsence(absenceDTO);

            if (success && AbsenceHandler != null)
            {
                AbsenceHandler(success);
            }

            return success;
        }

        public bool CreateAbsence(Absence absence)
        {
            AbsenceDTO absenceDTO = ConverterPool.GetConverter<Absence, AbsenceDTO>().Convert(absence);

            bool result = absenceRepository.CreateAbsence(absenceDTO);

            return result;
        }
    }
}
