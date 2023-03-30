using DataL.DTO;
using Logic.EmployeeTypes;
using Logic.interfaces;

namespace Logic
{
    public class Absence
    {
        private int id;
        private DateTime date;
        private string absenceReason;
        private string absenceDescription;
        private TicketStatus ticketStatus;

        public int Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public string AbsenceReason { get; set; }
        public string AbsenceDescription { get; set; }
        public TicketStatus TicketStatus { get; set; }

        public Absence(int id, Employee employee, DateTime date, string absenceReason, string absenceDescription, TicketStatus ticketStatus)
        {
            Id = id;
            Employee = employee;
            Date = date;
            AbsenceReason = absenceReason;
            AbsenceDescription = absenceDescription;
            TicketStatus = ticketStatus;
        }

        public Absence(AbsenceDTO absenceDTO)
        {
            Id = absenceDTO.Id;
            Employee = new Employee { Id = absenceDTO.Employee.Id };
            Date = absenceDTO.Date;
            AbsenceReason = absenceDTO.AbsenceReason;
            AbsenceDescription = absenceDTO.AbsenceDescription;
            TicketStatus = (TicketStatus)absenceDTO.TicketStatus;
        }

        public Absence()
        {

        }

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()} - Status: {TicketStatus}";
        }
    }
}