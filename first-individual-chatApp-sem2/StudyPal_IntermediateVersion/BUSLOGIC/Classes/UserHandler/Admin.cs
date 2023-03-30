using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.ComponentModel.DataAnnotations;

namespace BUSLOGIC.Classes.UserHandler
{
    public class Admin : User
    {
        //
        public Admin(UserDTO User) : base(User)
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
