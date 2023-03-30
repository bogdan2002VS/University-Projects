using BUSLOGIC.Exceptions;
using DAL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;




namespace BUSLOGIC.Classes.UserHandler
{
    public class UserManager : IUserManager
    {
        private QueryExecutor queryExecutorMediator;
        public UserManager(QueryExecutor queryExecutorMediator)
        {
           this.queryExecutorMediator = queryExecutorMediator ?? throw new ArgumentNullException(nameof(queryExecutorMediator));
        }

        public User LogIn(string username, string password)
        {
            List<UserDTO> usersDTOs = GetAllUsersForUsername(username);
            foreach (var userDTO in usersDTOs)
            {
                if (CheckPassword(userDTO.Salt, password, userDTO.Password))
                {
                    if (userDTO.IsAdmin == true)
                    {
                        return new Admin(userDTO);
                    }
                    return new BasicUser(userDTO);
                }
            }
            throw new InvalidCredentialsException("Username and password does not match");
        }

        public List<UserDTO> ProcessResultForUser(SqlDataReader reader)
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            while (reader.Read())
            {
                UserDTO userDTO = new UserDTO
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),
                    Salt = reader["Salt"].ToString(),
                    IsAdmin = (bool)reader["IsAdmin"]
                };
                userDTOs.Add(userDTO);

            }
            return userDTOs;
        }

        private object ProcessInsert(SqlDataReader reader)
        {
            if (reader.RecordsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public void AddUser(string name, string username, string password)
        {

            string salt = HashingSalting.CreateSalt(8);
            string hashedPassword = HashingSalting.GenerateSHA256Hash(password, salt);


            string query = $"INSERT INTO Users (Name ,Username, Password, Salt, IsAdmin) VALUES ('{name}','{username}','{hashedPassword}','{salt}', 0)";
            bool result = (bool)queryExecutorMediator.Execute(query, ProcessInsert);
            if (result == false)
            {
                throw new Exception("User could not be added in the database!");
            }
        }
        public void UpdateUser(string name, string username, string password, string id)
        {

            string salt = HashingSalting.CreateSalt(8);
            string hashedPassword = HashingSalting.GenerateSHA256Hash(password, salt);
            string query = null;
            bool result = false;
            string updateNameQuery = "";
            string updateUsernameQuery = "";
            string updatePasswordQuery = "";

            if (name != null)
            {
                updateNameQuery = $"Name = '{name}',";

            }
            if (username != null)
            {
                updateUsernameQuery = $"Username = '{username}',";
            }
            if (password != null)
            {
                updatePasswordQuery = $"Password = '{hashedPassword}', Salt ='{salt}'";
            }
            if (name == null && username == null && password == null)
            {
                throw new Exception("Nothing to update!");
            }

            query = $"UPDATE Users SET {updateNameQuery}{updateUsernameQuery}{updatePasswordQuery} WHERE ID = {id} ";
            result = (bool)queryExecutorMediator.Execute(query, ProcessInsert);
            if (result == false)
            {
                throw new Exception("User could not updated in the database!");
            }
        }

        private List<UserDTO> GetAllUsersForUsername(string username)
        {

            List<UserDTO> usersDTO = (List<UserDTO>)queryExecutorMediator.Execute(
             $"SELECT * FROM Users WHERE Username='{username}'",
            ProcessResultForUser);

            return usersDTO;
        }

        private bool CheckPassword(string salt, string passToCheck, string passFromDB)
        {
            string hashedCheckPassword = HashingSalting.GenerateSHA256Hash(passToCheck, salt);

            if (hashedCheckPassword.Equals(passFromDB))
            {
                return true;
            }

            return false;
        }

        public Boolean DeleteUser(string username, string password)
        {
            List<UserDTO> usersDTOs = GetAllUsersForUsername(username);
            foreach (var userDTO in usersDTOs)
            {
                if (CheckPassword(userDTO.Salt, password, userDTO.Password))
                {
                    if (userDTO.IsAdmin == false)
                    {
                        var result = (bool)queryExecutorMediator.Execute(
              $"Delete From Users where Username = '{username}' AND Salt = '{userDTO.Salt}'",
             DeleteUserProcessResult);
                        return (bool)result;
                    }
                }
            }
            throw new InvalidCredentialsException("Username and password does not match");


        }


        public object DeleteUserProcessResult(SqlDataReader reader)
        {
            return true;
        }

    }

}
