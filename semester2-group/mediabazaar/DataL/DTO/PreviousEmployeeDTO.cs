namespace DataL.DTO
{
    public class PreviousEmployeeDTO : PersonDTO
    {
        public PreviousEmployeeDTO(int id, string firstName, string lastName, string email, AddressDTO address, DateOnly dateOfBirth, string phoneNumber, int bsn, bool isActive) : base(id, firstName, lastName, email, address, dateOfBirth, phoneNumber, bsn, isActive)
        {
        }
    }
}
