using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DAL.DTO;
using Logic.Account.Validation;

namespace Logic.Model
{
    public class UserModel
    {
        public UserModel() 
        {

        }

        public UserModel(UserDTO userDTO)
        {
            ID = userDTO.ID;
            Username = userDTO.Username;
            Name = userDTO.Name;
            Email = userDTO.Email;
            Password = userDTO.Password;
            Role = userDTO.Role;
        }

        
        public int ID { get; set; } = 0;
        [UniqueUsername]
        public string Username { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%_]).{6,20})", ErrorMessage = "Please enter  a valid password(password should have: 6-20 caracters, first caracter should be capital , at least 1 of this caracters(@#$%_) and at least 1 number )")]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = String.Empty;

        public string Salt { get; set; } = string.Empty;


    }
}
