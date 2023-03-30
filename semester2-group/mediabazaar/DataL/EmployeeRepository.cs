using DataL.Config;
using DataL.DTO;
using DataL.interfaces;
using System.Data.SqlClient;

namespace DataL
{
    public class EmployeeRepository : IManagerRepository
    {
        public EmployeeRepository()
        {

        }

        public bool UpdateEmployee(EmployeeDTO e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "UPDATE Person SET firstName= @firstName, lastName= @lastName, email= @email, dateOfBirth= @dateOfBirth, phoneNumber= @phoneNumber, bsn= @bsn WHERE id= @id; UPDATE Employees SET type= @type WHERE id= @id; UPDATE Address SET streetName= @streetName, streetNumber= @streetNumber, zip= @zip, city= @city, country= @country WHERE personId= @id;";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@firstName", e.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", e.LastName);
                    cmd.Parameters.AddWithValue("@email", e.Email);
                    cmd.Parameters.AddWithValue("@dateOfBirth", e.DateOfBirth.ToString());
                    cmd.Parameters.AddWithValue("@phoneNumber", e.PhoneNumber);
                    cmd.Parameters.AddWithValue("@bsn", e.Bsn);
                    cmd.Parameters.AddWithValue("@id", e.Id);
                    cmd.Parameters.AddWithValue("@streetName", e.Address.StreetName);
                    cmd.Parameters.AddWithValue("@streetNumber", e.Address.StreetNumber);
                    cmd.Parameters.AddWithValue("@zip", e.Address.Zip);
                    cmd.Parameters.AddWithValue("@city", e.Address.City);
                    cmd.Parameters.AddWithValue("@country", e.Address.Country);
                    cmd.Parameters.AddWithValue("@type", e.EmployeeType);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows != 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong" + $" {ex.Message}");
            }
            return false;
        }

        public int AddEmployee(EmployeeDTO e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "INSERT INTO Person(firstName, lastName, email, dateOfBirth, phoneNumber, bsn, isActive) VALUES(@firstName, @lastName, @email, @dateOfBirth, @phoneNumber, @bsn, @isActive); SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@firstName", e.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", e.LastName);
                    cmd.Parameters.AddWithValue("@email", e.Email);
                    cmd.Parameters.AddWithValue("@dateOfBirth", e.DateOfBirth.ToString());
                    cmd.Parameters.AddWithValue("@phoneNumber", e.PhoneNumber);
                    cmd.Parameters.AddWithValue("@bsn", e.Bsn);
                    cmd.Parameters.AddWithValue("@isActive", 1);

                    decimal newID = (decimal)cmd.ExecuteScalar();

                    int iD = Convert.ToInt32(newID);

                    if (iD != 0)
                    {
                        string sqlCommandAddress = $"INSERT INTO [Address](personId, streetName, streetNumber, zip, city, country) VALUES(@personId, @streetName, @streetNumber, @zip, @city, @country)";
                        SqlCommand cmdAddress = new SqlCommand(sqlCommandAddress, conn);

                        cmdAddress.Parameters.AddWithValue("@personId", iD);
                        cmdAddress.Parameters.AddWithValue("@streetName", e.Address.StreetName);
                        cmdAddress.Parameters.AddWithValue("@streetNumber", e.Address.StreetNumber);
                        cmdAddress.Parameters.AddWithValue("@zip", e.Address.Zip);
                        cmdAddress.Parameters.AddWithValue("@city", e.Address.City);
                        cmdAddress.Parameters.AddWithValue("@country", e.Address.Country);

                        cmdAddress.ExecuteNonQuery();

                        string sqlCommandEmployee = $"INSERT INTO Employees(id, type) VALUES(@id, @type); INSERT INTO Credentials(employeeId, username) VALUES(@id, @username)";
                        SqlCommand cmdEmployees = new SqlCommand(sqlCommandEmployee, conn);

                        cmdEmployees.Parameters.AddWithValue("@id", iD);
                        cmdEmployees.Parameters.AddWithValue("@username", e.Username);
                        cmdEmployees.Parameters.AddWithValue("@type", e.EmployeeType);

                        cmdEmployees.ExecuteNonQuery();
                    }
                    return iD;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong" + $" {ex.Message}");
            }
        }

        public bool RemoveEmployee(int id, string type)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"DELETE FROM Absences WHERE employeeId = @id; DELETE FROM EmployeeShifts WHERE employeeId = @id DELETE FROM Warnings WHERE employeeId = @id; DELETE FROM Credentials WHERE employeeId = @id; DELETE FROM Employees WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows >= 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong" + $" {ex.Message}");
            }
            return false;
        }

        public EmployeeDTO GetEmployee(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT p.id, p.firstName, p.lastName, p.email, a.streetName, a.streetNumber, a.zip, a.city, a.country, p.dateOfBirth, p.phoneNumber, p.bsn, p.isActive, e.RFIDSerialNumber, e.type  FROM Person AS P  INNER JOIN Employees as E ON P.id = e.id INNER JOIN [Address] as a ON p.id = a.personId WHERE p.id = '{id}'";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    EmployeeDTO emp = null;
                    while (dr.Read())
                    {
                        emp = new EmployeeDTO
                        {
                            Id = Convert.ToInt32(dr[0]),
                            FirstName = dr[1].ToString(),
                            LastName = dr[2].ToString(),
                            Email = dr[3].ToString(),
                            Address = new AddressDTO
                            {
                                StreetName = dr[4].ToString(),
                                StreetNumber = dr[5].ToString(),
                                Zip = dr[6].ToString(),
                                City = dr[7].ToString(),
                                Country = dr[8].ToString(),
                            },
                            DateOfBirth = DateOnly.Parse(DateTime.Parse(dr[9].ToString()).ToShortDateString()),
                            PhoneNumber = dr[10].ToString(),
                            Bsn = Convert.ToInt32(dr[11]),
                            IsActive = (bool)dr[12],
                            SerialNumber = dr[13].ToString(),
                            EmployeeType = Convert.ToInt32(dr[14])
                        };
                    }
                    return emp;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public List<ShiftDTO> GetEmployeeShifts(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT id, [start], [end], MaxCashier, MaxSecurity, MaxStockManager, MaxDepartmentManager, MaxEmployeeManager, MaxHR FROM Shifts as S INNER JOIN EmployeeShifts as E on S.id = E.ShiftId\r\n\r\nWHERE E.employeeId = @id\r\n  AND s.start >= DATEADD(week, DATEDIFF(week, '18991231', getdate()), '18991231')\r\n  AND s.start < DATEADD(week, 1 + DATEDIFF(week, '18991231', getdate()), '18991231')";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);

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
                            MaxHR = Convert.ToInt32(dr[8])
                        });
                    }
                    return shifts;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public IEnumerable<EmployeeDTO> GetEmployeesShiftsAbsences()
        {
            List<EmployeeDTO> mainEmployeeList = GetEmployeesId();
            List<EmployeeDTO> employeesWithShifts = GetEmployeesShifts();
            List<EmployeeDTO> employeesWithAbsences = GetEmployeesAbsences();

            foreach(EmployeeDTO employee in mainEmployeeList)
            {
                foreach(EmployeeDTO employeesShifts in employeesWithShifts)
                {
                    if (employee.Id == employeesShifts.Id)
                    {
                        employee.ShiftDTOs = employeesShifts.ShiftDTOs;
                    }
                }

                foreach (EmployeeDTO employeesAbsences in employeesWithAbsences)
                {
                    if (employee.Id == employeesAbsences.Id)
                    {
                        employee.AbsenceDTOs = employeesAbsences.AbsenceDTOs;
                    }
                }
            }

            return mainEmployeeList;
        }

        public List<EmployeeDTO> GetEmployeesShifts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT E.employeeId, employee.type, S.id as shiftIda, [start], [end], MaxCashier, MaxSecurity, MaxStockManager, MaxDepartmentManager, MaxEmployeeManager, MaxHR, IsFull FROM Shifts as S INNER JOIN EmployeeShifts as E on S.id = E.ShiftId inner join Employees as employee on employee.id = e.employeeId ORDER BY e.employeEId";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    //get employees shifts
                    List<EmployeeDTO> employeesShifts = new List<EmployeeDTO>();

                    int previousEmployeeId = 0;
                    int employeeId = 0;
                    EmployeeDTO employee = null;

                    while (dr.Read())
                    {
                        employeeId = Convert.ToInt32(dr[0]);
                        if (previousEmployeeId != employeeId)
                        {
                            employee = new EmployeeDTO();
                            employee.Id = employeeId;
                            employee.EmployeeType = Convert.ToInt32(dr[1]);

                            employeesShifts.Add(employee);
                        }

                        if (employee != null)
                        {
                            ShiftDTO shift = new ShiftDTO
                            {
                                Id = Convert.ToInt32(dr[2]),
                                Start = DateTime.Parse(dr[3].ToString()),
                                End = DateTime.Parse(dr[4].ToString()),
                                MaxCashier = Convert.ToInt32(dr[5]),
                                MaxSecurity = Convert.ToInt32(dr[6]),
                                MaxStockManager = Convert.ToInt32(dr[7]),
                                MaxDepoManager = Convert.ToInt32(dr[8]),
                                MaxEmployeeManager = Convert.ToInt32(dr[9]),
                                MaxHR = Convert.ToInt32(dr[10]),
                                IsFull = Convert.ToBoolean(Convert.ToInt32(dr[11])),
                            };
                            employee.ShiftDTOs.Add(shift);
                        }

                        previousEmployeeId = employeeId;
                    }

                    return employeesShifts;
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + ex.ToString());
            }
        }

        public List<EmployeeDTO> GetEmployeesAbsences()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT employeeId, e.type,  a.id, date, absenceReason, absenceDescription, ticketStatus FROM Absences as a INNER JOIN Employees as e ON a.employeeId = e.id ORDER BY employeeId";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    List<EmployeeDTO> employeesAbsences = new List<EmployeeDTO>();

                    int previousEmployeeIdAbsences = 0;
                    int employeeIdAbsences = 0;
                    EmployeeDTO employeeAbsences = null;

                    while (dr.Read())
                    {
                        employeeIdAbsences = Convert.ToInt32(dr[0]);
                        if (previousEmployeeIdAbsences != employeeIdAbsences)
                        {
                            employeeAbsences = new EmployeeDTO();
                            employeeAbsences.Id = employeeIdAbsences;
                            employeeAbsences.EmployeeType = Convert.ToInt32(dr[1]);

                            employeesAbsences.Add(employeeAbsences);
                        }

                        if (employeeAbsences != null)
                        {
                            AbsenceDTO absenceDTO = new AbsenceDTO
                            {
                                Id = Convert.ToInt32(dr[2]),
                                Employee = new EmployeeDTO
                                {
                                    Id = Convert.ToInt32(dr[0])
                                },
                                Date = Convert.ToDateTime(dr[3]),
                                AbsenceReason = dr[4].ToString(),
                                AbsenceDescription = dr[5].ToString(),
                                TicketStatus = Convert.ToInt32(dr[6])
                            };

                            employeeAbsences.AbsenceDTOs.Add(absenceDTO);
                        }

                        previousEmployeeIdAbsences = employeeIdAbsences;
                    }

                    return employeesAbsences;
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public List<EmployeeDTO> GetEmployeesId()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT id, type FROM Employees";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    List<EmployeeDTO> employees = new List<EmployeeDTO>();
                    while (dr.Read())
                    {
                        EmployeeDTO emp = new EmployeeDTO
                        {
                            Id = Convert.ToInt32(dr[0]),
                            EmployeeType = Convert.ToInt32(dr[1])
                        };

                        employees.Add(emp);
                    }
                    return employees;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public List<WarningDTO> GetEmployeeWarnings(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT * FROM Warnings WHERE employeeId ='{id}'";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    List<WarningDTO> warnings = new List<WarningDTO>();
                    while (dr.Read())
                    {
                        warnings.Add(new WarningDTO(dr[1].ToString()));
                    }
                    return warnings;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public List<AbsenceDTO> GetEmployeeAbsences(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT a.id, a.date, a.absenceReason, a.absenceDescription, a.ticketStatus, e.id, p.firstName, p.lastName, p.email, p.phoneNumber FROM Absences as a INNER JOIN Employees as e on a.employeeId = e.id INNER JOIN Person as p on p.id = e.id WHERE employeeId=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dr = cmd.ExecuteReader();

                    List<AbsenceDTO> absences = new List<AbsenceDTO>();
                    while (dr.Read())
                    {
                        AbsenceDTO absenceDTO = new AbsenceDTO
                        {
                            Id = Convert.ToInt32(dr[0]),
                            Date = Convert.ToDateTime(dr[1].ToString()),
                            AbsenceReason = dr[2].ToString(),
                            AbsenceDescription = dr[3].ToString(),
                            TicketStatus = Convert.ToInt32(dr[4].ToString()),
                            Employee = new EmployeeDTO
                            {
                                Id = Convert.ToInt32(dr[5]),
                                FirstName = dr[6].ToString(),
                                LastName = dr[7].ToString(),
                                Email = dr[8].ToString(),
                                PhoneNumber = dr[9].ToString()
                            }
                        };

                        absences.Add(absenceDTO);
                    }
                    return absences;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public List<EmployeeDTO> GetEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT p.id, p.firstName, p.lastName, p.email, a.streetName, a.streetNumber, a.zip, a.city, a.country, p.dateOfBirth, p.phoneNumber, p.bsn, p.isActive, e.RFIDSerialNumber, e.type, e.Department, d.name  FROM Person AS P  INNER JOIN Employees as E ON P.id = e.id INNER JOIN [Address] as a ON p.id = a.personId INNER JOIN [Department] as d ON e.Department = d.id WHERE e.Type != 5";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    List<EmployeeDTO> employees = new List<EmployeeDTO>();
                    while (dr.Read())
                    {
                        EmployeeDTO emp = new EmployeeDTO
                        {
                            Id = Convert.ToInt32(dr[0]),
                            FirstName = dr[1].ToString(),
                            LastName = dr[2].ToString(),
                            Email = dr[3].ToString(),
                            Address = new AddressDTO
                            {
                                StreetName = dr[4].ToString(),
                                StreetNumber = dr[5].ToString(),
                                Zip = dr[6].ToString(),
                                City = dr[7].ToString(),
                                Country = dr[8].ToString(),
                            },
                            DateOfBirth = DateOnly.Parse(DateTime.Parse(dr[9].ToString()).ToShortDateString()),
                            PhoneNumber = dr[10].ToString(),
                            Bsn = Convert.ToInt32(dr[11]),
                            IsActive = (bool)dr[12],
                            SerialNumber = dr[13].ToString(),
                            EmployeeType = Convert.ToInt32(dr[14]),
                        };

                        employees.Add(emp);
                    }
                    return employees;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public List<EmployeeDTO> GetEmployeesOverView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT p.id, p.firstName, p.lastName, p.email, p.phoneNumber, e.type  FROM Person AS P  INNER JOIN Employees as E ON P.id = e.id WHERE e.Type != 5";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


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
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public List<EmployeeDTO> GetEmployeesManagers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT p.id, p.firstName, p.lastName, p.email, a.streetName, a.streetNumber, a.zip, a.city, a.country, p.dateOfBirth, p.phoneNumber, p.bsn, p.isActive, e.RFIDSerialNumber, e.type  FROM Person AS P  INNER JOIN Employees as E ON P.id = e.id INNER JOIN [Address] as a ON p.id = a.personId where type=4";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    List<EmployeeDTO> employees = new List<EmployeeDTO>();
                    while (dr.Read())
                    {
                        EmployeeDTO emp = new EmployeeDTO
                        {
                            Id = Convert.ToInt32(dr[0]),
                            FirstName = dr[1].ToString(),
                            LastName = dr[2].ToString(),
                            Email = dr[3].ToString(),
                            Address = new AddressDTO
                            {
                                StreetName = dr[4].ToString(),
                                StreetNumber = dr[5].ToString(),
                                Zip = dr[6].ToString(),
                                City = dr[7].ToString(),
                                Country = dr[8].ToString(),
                            },
                            DateOfBirth = DateOnly.Parse(DateTime.Parse(dr[9].ToString()).ToShortDateString()),
                            PhoneNumber = dr[10].ToString(),
                            Bsn = Convert.ToInt32(dr[11]),
                            IsActive = (bool)dr[12],
                            SerialNumber = dr[13].ToString(),
                            EmployeeType = Convert.ToInt32(dr[14])
                        };

                        employees.Add(emp);
                    }
                    return employees;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong" + $" {ex.Message}");
            }
        }

        public bool AssignEmployeeToDepartment(int departmentId, int employeeId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection._connectionstring))
                {
                    string sqlCommand = "UPDATE Employees SET Department=@Department WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sqlCommand, sqlConnection);

                    cmd.Parameters.AddWithValue("@Department", departmentId);
                    cmd.Parameters.AddWithValue("@id", employeeId);

                    sqlConnection.Open();

                    int affectedRows = cmd.ExecuteNonQuery();

                    sqlConnection.Close();

                    if(affectedRows > 0)
                    {
                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return false;
        }
    }
}
