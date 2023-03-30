using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.interfaces
{
    public interface ICredentialsRepository
    {
        bool UpdatePassword(int id, string[] password);
        int CheckCredentials(string username, string password);
        bool CheckUsername(string username);
    }
}
