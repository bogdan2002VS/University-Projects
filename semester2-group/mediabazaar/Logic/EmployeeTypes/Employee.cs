
using DataL.DTO;
namespace Logic

{
    public class Employee : Person
    {
        private Credentials employeeCredentials;
        private List<Shift> shifts;
        private List<Absence> absences;
        private List<Warnings> warnings;
        private RFIDControl rfid = new RFIDControl();
        private Department department;

        public RFIDControl Rfid
        {
            get { return rfid; }
            set { rfid = value; }
        }

        public Credentials EmployeeCredentials { get { return employeeCredentials; } private set { employeeCredentials = value; } }
        public List<Shift> Shifts { get; set; }
        public List<Absence> Absences { get; set; }
        public List<Warnings> Warning { get; set; }
        public Department Department { get; set; }

        public int ID { get; set; }

        public Employee(int id, string firstName, string lastName,
            string email, Address address, DateOnly dateOfBirth,
            string phoneNumber, int bsn, bool isActive, string username, string password, string serialNumber) : base(id, firstName, lastName, email,
                address, dateOfBirth, phoneNumber, bsn, isActive)
        {

            EmployeeCredentials = new Credentials(username, password, new RFIDControl(serialNumber));

            shifts = new List<Shift>();
            absences = new List<Absence>();
            warnings = new List<Warnings>();

        }

        public Employee(string firstName, string lastName,
            string email, Address address, DateOnly dateOfBirth,
            string phoneNumber, int bsn, bool isActive, string username, string password, string serialNumber) : base(firstName, lastName, email,
        address, dateOfBirth, phoneNumber, bsn, isActive)
        {

            EmployeeCredentials = new Credentials(username, password, new RFIDControl(serialNumber));
        }

        public Employee(int id, string firstName, string lastName,
            string email, Address address, DateOnly dateOfBirth,
            string phoneNumber, int bsn, bool isActive) : base(id, firstName, lastName, email,
        address, dateOfBirth, phoneNumber, bsn, isActive)
        {
            
        }

        public Employee() : base()
        {

        }
        public Employee(EmployeeDTO employeeDTO)
        {
            Id = employeeDTO.ID;
            rfid.SerialNumber = employeeDTO.SerialNumber;
        }
    }
}