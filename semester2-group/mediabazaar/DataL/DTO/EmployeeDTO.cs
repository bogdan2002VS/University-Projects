namespace DataL.DTO
{
    public class EmployeeDTO : PersonDTO
    {
        public EmployeeDTO(int id, string firstName, string lastName, string email, AddressDTO addressDTO, DateOnly dateOfBirth, string phoneNumber, int bsn, bool isActive, string username, string password, string serialNumber, int employeeType) : base(id, firstName, lastName, email, addressDTO, dateOfBirth, phoneNumber, bsn, isActive)
        {

            Username = username;
            Password = password;
            SerialNumber = serialNumber;
            EmployeeType = employeeType;
        }

        public EmployeeDTO(string firstName, string lastName, string email, AddressDTO addressDTO, DateOnly dateOfBirth, string phoneNumber, int bsn, bool isActive, string serialNumber, int employeeType) : base(firstName, lastName, email, addressDTO, dateOfBirth, phoneNumber, bsn, isActive)
        {
            SerialNumber = serialNumber;
            EmployeeType = employeeType;
        }

        public EmployeeDTO(int id, string firstName, string lastName, string email, string phoneNumber, int employeeType) : base(id, firstName, lastName, email, phoneNumber)
        {
            EmployeeType = employeeType;
        }

        public EmployeeDTO(int id) : base(id)
        {

        }

        public EmployeeDTO()
        {
            ShiftDTOs = new List<ShiftDTO>();
            AbsenceDTOs = new List<AbsenceDTO>();
        }
        public EmployeeDTO(int id, string serialNumber ,int employeeType)
        {
            this.ID = id;
            this.SerialNumber = serialNumber;
            this.EmployeeType = employeeType;
        }
        
        public int ID { get; set; }
        public int EmployeeType { get; set; }
        public string Username { get; set; }
        public string? Password { get; set; }
        public string SerialNumber { get; set; }
        public bool IsAssignd { get; set; }
        public List<ShiftDTO> ShiftDTOs { get; set; }
        public List<AbsenceDTO> AbsenceDTOs { get; set; }
    }
}
