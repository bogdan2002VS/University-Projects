namespace Logic.EmployeeTypes
{
    public class StockManager : Employee
    {
        public StockManager(int id, string firstName, string lastName,
            string email, Address address, DateOnly dateOfBirth,
            string phoneNumber, int bsn, bool isActive, string username, string password, string serialNumber) : base(id, firstName, lastName, email, address, dateOfBirth, phoneNumber, bsn, isActive, username, password, serialNumber)
        {
        }

        public StockManager(string firstName, string lastName,
    string email, Address address, DateOnly dateOfBirth,
    string phoneNumber, int bsn, bool isActive, string username, string password, string serialNumber) : base(firstName, lastName, email, address, dateOfBirth, phoneNumber, bsn, isActive, username, password, serialNumber)
        {
        }

        public StockManager(int id, string firstName, string lastName,
string email, Address address, DateOnly dateOfBirth,
string phoneNumber, int bsn, bool isActive) : base(id, firstName, lastName, email, address, dateOfBirth, phoneNumber, bsn, isActive)
        {
        }
    }
}