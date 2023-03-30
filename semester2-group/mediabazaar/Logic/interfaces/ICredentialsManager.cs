using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.interfaces
{
    public interface ICredentialsManager
    {
        bool UpdatePassword(int employeeId, string password);
        bool CheckUsername(string username);
        int CheckCredentials(string username, string password);
    }
}
