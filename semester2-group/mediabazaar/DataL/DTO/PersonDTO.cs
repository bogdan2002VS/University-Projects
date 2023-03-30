namespace DataL.DTO
{
    public class PersonDTO
    {
        public PersonDTO(int id, string firstName, string lastName, string email, AddressDTO address, DateOnly dateOfBirth, string phoneNumber, int bsn, bool isActive)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Bsn = bsn;
            IsActive = isActive;
        }

        public PersonDTO(string firstName, string lastName, string email, AddressDTO address, DateOnly dateOfBirth, string phoneNumber, int bsn, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Bsn = bsn;
            IsActive = isActive;
        }

        public PersonDTO(int id, string firstName, string lastName, string email, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public PersonDTO(int id)
        {
            Id = id;
        }

        public PersonDTO()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public AddressDTO Address { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public int Bsn { get; set; }
        public bool IsActive { get; set; }
    }
}
