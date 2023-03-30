using DataL.Config;
using DataL.DTO;
using DataL.interfaces;
using System.Data.SqlClient;

namespace DataL
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private const string _sqlConnectionString = DBConnection._connectionstring; 

        public DepartmentRepository()
        {

        }

        public DepartmentDTO[] GetDepartments()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
                {
                    string sqlQuery = $"SELECT * FROM Department";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);

                    connection.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    List<DepartmentDTO> departmentDTOs = new List<DepartmentDTO>();
                    while (dr.Read())
                    {
                        DepartmentDTO department = new DepartmentDTO(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]));

                        departmentDTOs.Add(department);
                    }
                    return departmentDTOs.ToArray();
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong");
            }
        }

        public DepartmentDTO GetDepartment(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT FROM Department WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dr = cmd.ExecuteReader();

                    DepartmentDTO departmentDTO = null;
                    while (dr.Read())
                    {
                        DepartmentDTO department = new DepartmentDTO(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]));

                        departmentDTO = department;
                    }
                    return departmentDTO;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public bool AddDepartment(DepartmentDTO department)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "INSERT INTO Department(name) VALUES (@name)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", department.Name);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return false;
        }

        public bool RemoveDepartment(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"DELETE FROM Department WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows != 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return false;
        }

        public bool UpdateDepartment(DepartmentDTO department)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"UPDATE Department SET name=@name WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", department.Name);
                    cmd.Parameters.AddWithValue("@id", department.Id);

                    int affectedRows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (affectedRows == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return false;
        }
    }
}
