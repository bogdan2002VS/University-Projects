using DataL.DTO;
using DataL.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataL.Config;

namespace DataL
{
    public class AbsenceRepository : IAbsenceRepository
    {
        public bool CreateAbsence(AbsenceDTO absenceDTO)
        {         
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"INSERT INTO Absences(employeeId, date, absenceReason, absenceDescription, ticketStatus) VALUES(@employeeId, @date, @absenceReason, @absenceDescription, @ticketStatus)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@employeeId", absenceDTO.Employee.Id);
                    cmd.Parameters.AddWithValue("@date", absenceDTO.Date);
                    cmd.Parameters.AddWithValue("@absenceReason", absenceDTO.AbsenceReason);
                    cmd.Parameters.AddWithValue("@absenceDescription", absenceDTO.AbsenceDescription);
                    cmd.Parameters.AddWithValue("@ticketStatus", absenceDTO.TicketStatus);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows == 0)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ups could not create Absence" + ex.ToString());
            }
        }

        public IEnumerable<AbsenceDTO> GetAbsenceDTOs()
        {        
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT a.id, a.date, a.absenceReason, a.absenceDescription, a.ticketStatus, e.id, p.firstName, p.lastName, p.email, p.phoneNumber FROM Absences as a INNER JOIN Employees as e on a.employeeId = e.id INNER JOIN Person as p on p.id = e.id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


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
                throw new ArgumentException("Something went wrong" + ex.ToString());
            }
        }

        public bool UpdateAbsence(AbsenceDTO absence)
        {  
            try         
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "UPDATE Absences SET employeeId= @employeeId, date= @date, absenceReason= @absenceReason, absenceDescription= @absenceDescription, ticketStatus= @ticketStatus WHERE id= @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@employeeId", absence.Employee.Id);
                    cmd.Parameters.AddWithValue("@id", absence.Id);
                    cmd.Parameters.AddWithValue("@date", absence.Date);
                    cmd.Parameters.AddWithValue("@absenceReason", absence.AbsenceReason);
                    cmd.Parameters.AddWithValue("@absenceDescription", absence.AbsenceDescription);
                    cmd.Parameters.AddWithValue("@ticketStatus", absence.TicketStatus);

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
    }
}
