using System.ComponentModel.DataAnnotations;

namespace Logic
{
    public class Person
    {
        private int? id;
        private string firstName;
        private string lastName;
        private string email;
        private Address personAddress;
        private DateOnly dateOfBirth;
        private string phoneNumber;
        private int bsn;
        private bool isActive;

        public Person(int id, string firstName, string lastName, 
            string email, Address address, DateOnly dateOfBirth,
            string phoneNumber, int bsn, bool isActive)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PersonAddress = address;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Bsn = bsn;
            IsActive = isActive;
        }

        public Person(string firstName, string lastName,
            string email, Address address, DateOnly dateOfBirth,
            string phoneNumber, int bsn, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PersonAddress = address;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Bsn = bsn;
            IsActive = isActive;
        }

        public Person()
        {
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get { return email; } set { email = value; } }
        public Address PersonAddress { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public int Bsn { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{Id} - {FirstName} - {LastName} - {Email} - {DateOfBirth} - {PhoneNumber} - {Bsn}";
        }

    }
}