using DataL;
using DataL.interfaces;
using Logic.EmployeeTypes;
using Logic.interfaces;

namespace Logic
{
    public class LoginLogic : ILogIn
    {
        private readonly ILogInRep logInRep;
        private readonly IEmployee employeeManager;
        private readonly ICredentialsManager credentialsManager;
        public LoginLogic(ILogInRep logIn, IEmployee employeeManager, ICredentialsManager credentialsManager)
        {
            logInRep = logIn;
            this.employeeManager = employeeManager;
            this.credentialsManager = credentialsManager;
        }
        public Employee LogIn(string username, string password)
        {
            if (!credentialsManager.CheckUsername(username))
                throw new ArgumentException("Username doesnt exist");

            string salt = GetSalt(username);
            string passwordHashed = Hashing.HashPassword(password, salt);

            int employeeId = credentialsManager.CheckCredentials(username, passwordHashed);

            if (employeeId == 0)
                throw new ArgumentException("Password isn't correct");

            Employee employee = employeeManager.GetEmployee(employeeId).Value;

            return employee;
        }

        public string GetSalt(string username)
        {
            string salt = logInRep.GetSalt(username);

            return salt;
        }
       //Guid myuuidAsString = Guid.NewGuid();  //UUID Generator Convert To string myuuidAsString.ToString()
        //not supposed to be here
    }
}