namespace Logic
{
    public class PreviousEmployee : Person
    {
        public PreviousEmployee(int id, string firstName, string lastName,
            string email, Address address, DateOnly dateOfBirth,
            string phoneNumber, int bsn, bool isActive) : base(id, firstName, lastName, email, address, dateOfBirth, phoneNumber, bsn, isActive)
        {
        }
    }
}