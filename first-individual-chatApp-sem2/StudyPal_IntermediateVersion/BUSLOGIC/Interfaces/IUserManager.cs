using BUSLOGIC.Classes.UserHandler;
using System;
using System.Collections.Generic;
using System.Text;
using BUSLOGIC.Classes;

namespace BUSLOGIC
{
    public interface IUserManager
    {

        public void UpdateUser(string name, string username, string password, string id);
        public User LogIn(string username, string password);

    }
}
