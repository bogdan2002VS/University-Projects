using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.DTO;
using DAL.Config;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {

        public int CreateUser(UserDTO userDTO)
        {
            try
            {
                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "INSERT INTO Users(name, username, password, email, salt, role) OUTPUT inserted.ID " +
                    "values(@nam, @usr, @psw, @eml, @slt, @rol)";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;
                    sqlHandler.Parameters.Add("@usr", System.Data.SqlDbType.VarChar).Value = userDTO.Username;
                    sqlHandler.Parameters.Add("@psw", System.Data.SqlDbType.VarChar).Value = userDTO.Password;
                    sqlHandler.Parameters.Add("@eml", System.Data.SqlDbType.VarChar).Value = userDTO.Email;
                    sqlHandler.Parameters.Add("@slt", System.Data.SqlDbType.VarChar).Value = userDTO.Salt;
                    sqlHandler.Parameters.Add("@nam", System.Data.SqlDbType.VarChar).Value = userDTO.Name;
                    sqlHandler.Parameters.Add("@rol", System.Data.SqlDbType.VarChar).Value = userDTO.Role;
                    var reader = sqlHandler.ExecuteReader();

                    if (reader.Read())
                    {
                        return Convert.ToInt32(reader["id"]);
                    }
                    else return -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("UserService " + userDTO.Role + " create ERR",ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }


        public UserDTO ReadUserById(int userId)
        {
            UserDTO userDTO = new UserDTO();

            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = "SELECT id, name, username, password, email, salt, role FROM Users WHERE id = @id";
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;
                sqlHandler.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = userId;

                var reader = sqlHandler.ExecuteReader();

                if (reader.Read())
                {
                    userDTO.ID = Convert.ToInt32(reader["id"]);
                    userDTO.Name = reader["name"].ToString();
                    userDTO.Username = reader["username"].ToString();
                    userDTO.Password = reader["password"].ToString();
                    userDTO.Email = reader["email"].ToString();
                    userDTO.Salt = reader["salt"].ToString();
                    userDTO.Role = reader["role"].ToString();
                }
                Console.WriteLine("UserService read OK");
                return userDTO;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("could not read user",ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }
        public UserDTO ReadUserByUsername(string username)
        {
            UserDTO userDTO = new UserDTO();

            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = "SELECT id, name, username, password, email, salt, role FROM Users WHERE username = @usr";
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;
                sqlHandler.Parameters.Add("@usr", System.Data.SqlDbType.VarChar).Value = username;

                var reader = sqlHandler.ExecuteReader();

                if (reader.Read())
                {
                    userDTO.ID = Convert.ToInt32(reader["id"]);
                    userDTO.Name = reader["name"].ToString();
                    userDTO.Username = reader["username"].ToString();
                    userDTO.Password = reader["password"].ToString();
                    userDTO.Email = reader["email"].ToString();
                    userDTO.Salt = reader["salt"].ToString();
                    userDTO.Role = reader["role"].ToString();
                }
                return userDTO;

            }
            catch (Exception ex)
            {
                throw new Exception("Could not read user by username, sorry", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public void UpdateUser(UserDTO userDTO)
        {
            try
            {
                DBConnection.connection.Open();
                using (SqlCommand user = new SqlCommand())
                {
                    user.CommandText = "UPDATE Users SET username = @usr, email = @eml," +
                        "name = @nam WHERE id = @id";
                    user.CommandType = System.Data.CommandType.Text;
                    user.Connection = DBConnection.connection;
                    user.Parameters.Add("@usr", System.Data.SqlDbType.VarChar).Value = userDTO.Username;
                    user.Parameters.Add("@eml", System.Data.SqlDbType.VarChar).Value = userDTO.Email;
                    user.Parameters.Add("@nam", System.Data.SqlDbType.VarChar).Value = userDTO.Name;
                    user.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = userDTO.ID;
                    var reader = user.ExecuteReader();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("cant  updated this user", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public void DeleteUser(int userId)
        {

            try
            {
                DBConnection.connection.Open();
                using (SqlCommand user = new SqlCommand())
                {
                    user.CommandText = "DELETE FROM Users WHERE id = @id";
                    user.CommandType = System.Data.CommandType.Text;
                    user.Connection = DBConnection.connection;
                    user.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = userId;
                    var reader = user.ExecuteReader();

                    while (reader.Read()) { }
                    Console.WriteLine("UserService delete OK");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Cant delete user",ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

      
        public bool UsernameExists(string username)
        {
            string userName = null;
            try
            {
                DBConnection.connection.Open();
                using (SqlCommand user = new SqlCommand())
                {
                    user.CommandText = "Select username FROM Users WHERE username = @un";
                    user.CommandType = System.Data.CommandType.Text;
                    user.Connection = DBConnection.connection;
                    user.Parameters.Add("@un", System.Data.SqlDbType.VarChar).Value = username;
                    var reader = user.ExecuteReader();

                    if (reader.Read())
                    {
                        userName = reader["username"].ToString();
                    }
                   
                }
                if (userName == null || userName == String.Empty)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Cant read username", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }
    }
}
