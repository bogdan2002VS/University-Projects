using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.EmployeeTypes;

namespace Logic.interfaces
{
    public interface ILogIn
    {
        Employee LogIn(string username, string password);
    }
}
