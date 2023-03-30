using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DAL.DTO;

namespace Logic.Model
{
    public class UserProfileModel
    {
        public UserProfileModel()
        {

        }
        public UserProfileModel(UserDTO userDTO)
        {
            ID = userDTO.ID;
            Username = userDTO.Username;
            Name = userDTO.Name;
            Email = userDTO.Email;
            Password = userDTO.Password;
        }


        public int ID { get; set; } = 0;
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string Salt { get; set; } = string.Empty;

    }
}
