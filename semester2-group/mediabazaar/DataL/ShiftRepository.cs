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
    public class ShiftRepository : IShiftRepository
    {
        public bool CreateShift(ShiftDTO shift)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "INSERT INTO Shifts ([start], [end], MaxCashier, MaxSecurity, MaxStockManager, MaxDepartmentManager, MaxEmployeeManager, MaxHR, isFull) " +
                        "VALUES(@start, @end, @maxCashier, @maxSecurity, @maxstockmanager, @maxdepartmentmanager, @maxeployeemnager, @maxhr, @IsFull)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@start", shift.Start);
                    cmd.Parameters.AddWithValue("@end", shift.End);
                    cmd.Parameters.AddWithValue("@maxCashier", shift.MaxCashier);
                    cmd.Parameters.AddWithValue("@maxSecurity", shift.MaxSecurity);
                    cmd.Parameters.AddWithValue("@maxstockmanager", shift.MaxStockManager);
                    cmd.Parameters.AddWithValue("@maxdepartmentmanager", shift.MaxDepoManager);
                    cmd.Parameters.AddWithValue("@maxeployeemnager", shift.MaxEmployeeManager);
                    cmd.Parameters.AddWithValue("@maxhr", shift.MaxHR);
                    cmd.Parameters.AddWithValue("@isFull", shift.IsFull);

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

        public bool AssignShift(int employeeId, int shiftId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "INSERT INTO EmployeeShifts (ShiftId, employeeId) VALUES(@shiftId, @employeeId)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@shiftId", shiftId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        public List<ShiftDTO> GetShifts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT id, [start], [end], MaxCashier, MaxSecurity, MaxStockManager, MaxDepartmentManager, MaxEmployeeManager, MaxHR, IsFull FROM Shifts\r\nWhere [start] >= DATEADD(week, DATEDIFF(week, '18991231', getdate()), '18991231')\r\n  AND [start] < DATEADD(week, 1 + DATEDIFF(week, '18991231', getdate()), '18991231')";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    List<ShiftDTO> shifts = new List<ShiftDTO>();
                    while (dr.Read())
                    {
                        shifts.Add(new ShiftDTO
                        {
                            Id = Convert.ToInt32(dr[0]),
                            Start = DateTime.Parse(dr[1].ToString()),
                            End = DateTime.Parse(dr[2].ToString()),
                            MaxCashier = Convert.ToInt32(dr[3]),
                            MaxSecurity = Convert.ToInt32(dr[4]),
                            MaxStockManager = Convert.ToInt32(dr[5]),
                            MaxDepoManager = Convert.ToInt32(dr[6]),
                            MaxEmployeeManager = Convert.ToInt32(dr[7]),
                            MaxHR = Convert.ToInt32(dr[8]),
                            IsFull = Convert.ToBoolean(dr[9].ToString())
                        });
                    }
                    return shifts;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + ex.ToString());
            }
        }

        public IEnumerable<EmployeeDTO> GetShiftEmployees(ShiftDTO shiftDTO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"select p.id, p.firstName, p.lastName, p.email, p.phoneNumber, e.type from EmployeeShifts as es inner join Employees as e ON es.employeeId = e.id inner join Person as p on p.id = e.id inner join Shifts as s On s.id = es.ShiftId where s.id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", shiftDTO.Id);

                    SqlDataReader dr = cmd.ExecuteReader();

                    List<EmployeeDTO> employees = new List<EmployeeDTO>();
                    while (dr.Read())
                    {
                        EmployeeDTO employeeDTO = new EmployeeDTO
                        {
                            Id = Convert.ToInt32(dr[0]),
                            FirstName = dr[1].ToString(),
                            LastName = dr[2].ToString(),
                            Email = dr[3].ToString(),
                            PhoneNumber = dr[4].ToString(),
                            EmployeeType = Convert.ToInt32(dr[5])
                        };

                        employees.Add(employeeDTO);
                    }
                    return employees;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong");
            }
        }

        public bool UpdateShift(ShiftDTO shiftDTO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "UPDATE Shifts SET [start]= @start, [end]= @end, MaxCashier= @MaxCashier, MaxSecurity= @MaxSecurity, MaxStockManager= @MaxStockManager, MaxDepartmentManager= @MaxDepartmentManager,  MaxEmployeeManager= @MaxEmployeeManager,  MaxHR= @MaxHR, IsFull=@IsFull WHERE id= @id;";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@start", shiftDTO.Start);
                    cmd.Parameters.AddWithValue("@end", shiftDTO.End);
                    cmd.Parameters.AddWithValue("@MaxCashier", shiftDTO.MaxCashier);
                    cmd.Parameters.AddWithValue("@MaxSecurity", shiftDTO.MaxSecurity);
                    cmd.Parameters.AddWithValue("@MaxStockManager", shiftDTO.MaxStockManager);
                    cmd.Parameters.AddWithValue("@MaxDepartmentManager", shiftDTO.MaxDepoManager);
                    cmd.Parameters.AddWithValue("@MaxEmployeeManager", shiftDTO.MaxEmployeeManager);
                    cmd.Parameters.AddWithValue("@MaxHR", shiftDTO.MaxHR);
                    cmd.Parameters.AddWithValue("@id", shiftDTO.Id);
                    cmd.Parameters.AddWithValue("@isFull", shiftDTO.IsFull);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows != 0)
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

        public bool CheckEmployeeInShift(int employeeId, int shiftId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "select count(ShiftId) from EmployeeShifts Where ShiftId = @shiftId and employeeId = @employeeId";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@shiftId", shiftId);

                    int affectedRows = (int)cmd.ExecuteScalar();

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
