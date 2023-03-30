using System;
using System.Collections.Generic;
using System.Text;

namespace BUSLOGIC.Interfaces
{
    internal interface IHasAdminRights
    {
        public int CreateSubject(string name , string description);
    }
}
