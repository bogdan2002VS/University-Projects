using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.interfaces
{
    public interface ILogInRep
    {
        string GetSalt(string username);
    }
}
