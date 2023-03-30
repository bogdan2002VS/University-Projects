using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BUSLOGIC.Classes.UserHandler
{
    public class BasicUser : User
    {
        public BasicUser(UserDTO User) : base(User)
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
