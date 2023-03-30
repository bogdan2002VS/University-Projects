using DataL.Config;
using DataL.DTO;
using DataL.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL
{
    public class LogInData : ILogInRep
    {
        EmployeeRepository employeeRepository;

        public LogInData()
        {
            employeeRepository = new EmployeeRepository();
        }

        public string GetSalt(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT salt FROM Credentials WHERE username = @username";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", username);

                    string salt = (string)cmd.ExecuteScalar();

                    return salt;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }
    }
}
