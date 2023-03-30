using DataL.DTO;
using Logic.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class AbsenceConverter : IConverter<Absence, AbsenceDTO>
    {
        public AbsenceDTO Convert(Absence source_object)
        {
            EmployeeDTO employee = new EmployeeDTO
            {
                Id = source_object.Employee.Id,
                FirstName = source_object.Employee.FirstName,
                LastName = source_object.Employee.LastName,
                Email = source_object.Employee.Email,
                PhoneNumber = source_object.Employee.PhoneNumber
            };

            AbsenceDTO absenceDTO = new AbsenceDTO
            {
                Id = source_object.Id,
                Date = source_object.Date,
                AbsenceDescription = source_object.AbsenceDescription,
                AbsenceReason = source_object.AbsenceReason,
                TicketStatus = (int)source_object.TicketStatus,
                Employee = employee,
            };

            return absenceDTO;
        }

        public Absence Convert(AbsenceDTO source_object)
        {
            Employee employee = new Employee
            {
                Id = source_object.Employee.Id,
                FirstName = source_object.Employee.FirstName,
                LastName = source_object.Employee.LastName,
                Email = source_object.Employee.Email,
                PhoneNumber = source_object.Employee.PhoneNumber
            };

            Absence absenceDTO = new Absence
            {
                Id = source_object.Id,
                Date = source_object.Date,
                AbsenceDescription = source_object.AbsenceDescription,
                AbsenceReason = source_object.AbsenceReason,
                TicketStatus = (TicketStatus)source_object.TicketStatus,
                Employee = employee,
            };

            return absenceDTO;
        }

        public AbsenceDTO[] Convert(List<Absence> source_object)
        {
            List<AbsenceDTO> absenceDTOs = new List<AbsenceDTO>();
            foreach (Absence item in CollectionsMarshal.AsSpan(source_object))
            {
                absenceDTOs.Add(Convert(item));
            }

            return absenceDTOs.ToArray();
        }

        public Absence[] Convert(List<AbsenceDTO> source_object)
        {
            List<Absence> absenceDTOs = new List<Absence>();
            foreach (AbsenceDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                absenceDTOs.Add(Convert(item));
            }

            return absenceDTOs.ToArray();
        }
    }
}
