using DataL.Config;
using DataL.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL
{
    public class CredentialsRepository : ICredentialsRepository
    {
        public bool UpdatePassword(int id, string[] password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"UPDATE Credentials SET [password]=@password, salt=@salt WHERE employeeId=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@password", password[0]);
                    cmd.Parameters.AddWithValue("@salt", password[1]);
                    cmd.Parameters.AddWithValue("@id", id);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ups the system could not update the password");
            }
            return false;
        }

        public int CheckCredentials(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT employeeId FROM Credentials WHERE username=@username and [password]=@password";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader dr = cmd.ExecuteReader();

                    int id = 0;
                    while (dr.Read())
                    {
                        id = Convert.ToInt32(dr[0]);
                    }
                    return id;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public bool CheckUsername(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT COUNT(employeeId) FROM Credentials WHERE username = @username";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", username);

                    int id = (int)cmd.ExecuteScalar();

                    if (id == 0)
                        return false;

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }
    }
}
