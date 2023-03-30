using System;
using System.Collections.Generic;
using System.Text;


namespace DAL
{ 
    public class UserDTO
    {
        public string Name;
        public int ID;
        public string Username;
        public string Password;
        public string Salt;
        public bool IsAdmin;
    }
}