using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.ComponentModel.DataAnnotations;

namespace BUSLOGIC.Classes.UserHandler
{
    public class User
    {
        [Required(ErrorMessage = "Please fill in your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill in your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please fill in your username")]
        public string Username { get; set; }

        public int ID { get; set; }

        public User(UserDTO User)
        {
            Name = User.Name;
            ID = User.ID;
            Username = User.Username;
            Password = User.Password;

        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Name == user.Name &&
                   Password == user.Password &&
                   Username == user.Username &&
                   ID == user.ID;
        }
    }

}
