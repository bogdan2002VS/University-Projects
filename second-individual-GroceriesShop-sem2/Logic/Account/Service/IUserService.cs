using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;
using Logic.Model;


namespace Logic.Account.Service
{
    public interface IUserService
    {

        public int RegisterCustomer(UserModel user);

        public int RegisterEmployee(UserModel user);

        public void UpdateUser(UserProfileModel user);

        public UserProfileModel ReadUserProfile(int userId);

        public void DeleteUser(int userId);

        public UserModel Login(UserModel user);

        public bool UsernameExists(string username);



    }
}
