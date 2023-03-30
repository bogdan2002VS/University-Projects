using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL.Repository
{
    public interface IUserRepository
    {
        public int CreateUser(UserDTO userDTO);

        public UserDTO ReadUserById(int userId);
        public UserDTO ReadUserByUsername(string username);

        public void UpdateUser(UserDTO userDTO);

        public void DeleteUser(int userId);
        public bool UsernameExists(string username);


    }
}
