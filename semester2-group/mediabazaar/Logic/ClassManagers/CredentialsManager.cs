using DataL.interfaces;
using Logic.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ClassManagers
{
    public class CredentialsManager : ICredentialsManager
    {
        private readonly ICredentialsRepository credentialsRepository;
        public CredentialsManager(ICredentialsRepository credentialsRepository)
        {
            this.credentialsRepository = credentialsRepository;
        }
        public bool UpdatePassword(int employeeId, string password)
        {
            string[] passwordAndSalt = Hashing.HashPassword(password);

            bool result = credentialsRepository.UpdatePassword(employeeId, passwordAndSalt);

            return result;
        }
        public bool CheckUsername(string username)
        {
            bool result = credentialsRepository.CheckUsername(username);

            return result;
        }

        public int CheckCredentials(string username, string password)
        {
            int employeeId = credentialsRepository.CheckCredentials(username, password);
            
            return employeeId;
        }
    }
}
