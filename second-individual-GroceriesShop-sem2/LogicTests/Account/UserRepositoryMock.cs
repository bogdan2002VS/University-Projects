using DAL.DTO;
using DAL.Repository;
using Logic.Account.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Account
{
    public class UserRepositoryMock : IUserRepository
    {
        public UserDTO UserToCreate; 
        public UserDTO UserToUpdate;

        public int CreateUser(UserDTO userDTO)
        {
            UserToCreate = userDTO ;
            return 123;
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDTO ReadUserById(int userId)
        {
            string salt = HashingSalting.CreateSalt(8);
            string hashedPassword = HashingSalting.GenerateSHA256Hash("password", salt);

            return new UserDTO()
            {
                ID = 1,
                Name = "Bogdan Calinescu",
                Email = "my@email.com",
                Password = hashedPassword,
                Role = "Customer",
                Salt = salt,
                Username = "Bogdan"
                
            };
        }

        public UserDTO ReadUserByUsername(string username)
        {
            string salt = HashingSalting.CreateSalt(8);
            string hashedPassword = HashingSalting.GenerateSHA256Hash("password", salt);

            return new UserDTO()
            {
                ID = 1,
                Name = "Bogdan Calinescu",
                Email = "my@email.com",
                Password = hashedPassword,
                Role = "Customer",
                Salt = salt,
                Username = "Bogdan"

            };
        }

        public void UpdateUser(UserDTO userDTO)
        {
            UserToUpdate = userDTO;
        }

        public bool UsernameExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}
