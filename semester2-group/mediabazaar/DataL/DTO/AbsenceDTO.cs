using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.DTO
{
    public class AbsenceDTO
    {
        public AbsenceDTO(int id, EmployeeDTO Employee, DateTime date, string absenceReason, string absenceDescription, int ticketStatus)
        {
            Id = id;
            this.Employee = Employee;
            Date = date;
            AbsenceReason = absenceReason;
            AbsenceDescription = absenceDescription;
            TicketStatus = ticketStatus;
        }

        public AbsenceDTO()
        {

        }
        public int Id { get; set; }
        public EmployeeDTO Employee { get; set; }
        public DateTime Date { get; set; }
        public string AbsenceReason { get; set; }
        public string AbsenceDescription { get; set; }
        public int TicketStatus { get; set; }
    }
}
