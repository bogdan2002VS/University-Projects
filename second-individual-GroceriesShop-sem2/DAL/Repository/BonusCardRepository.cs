using DAL.Config;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class BonusCardRepository : IBonusCardRepository
    {
        public void CreateUserBonusCard(BonusCardDTO bonusCardDTO)
        {
            try
            {
                DBConnection.connection.Open();
                using (SqlCommand user = new SqlCommand())
                {
                    user.CommandText = "Insert INTO [BonusCard] (User_Id, TotalBonus) Values (@userid, 0)";
                    user.CommandType = System.Data.CommandType.Text;
                    user.Connection = DBConnection.connection;
                    user.Parameters.Add("@userid", System.Data.SqlDbType.Int).Value = bonusCardDTO.UserId;
                    user.Parameters.Add("@points", System.Data.SqlDbType.Int).Value = bonusCardDTO.TotalBonusPoints;
                    var reader = user.ExecuteReader();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Could not create bonus card for this user please try again later", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public BonusCardDTO GetBonusCard(int userId)
        {
            try
            {
                BonusCardDTO bonusCardDTO = null;
                DBConnection.connection.Open();
                using (SqlCommand user = new SqlCommand())
                {
                    user.CommandText = "select CardId, user_id, TotalBonus from [BonusCard] where user_id=@userid";
                    user.CommandType = System.Data.CommandType.Text;
                    user.Connection = DBConnection.connection;
                    user.Parameters.Add("@userid", System.Data.SqlDbType.Int).Value = userId;
                    var reader = user.ExecuteReader();
                    if (reader.Read())
                    {
                        bonusCardDTO = new BonusCardDTO();
                        bonusCardDTO.ID = Convert.ToInt32(reader["CardId"]);
                        bonusCardDTO.TotalBonusPoints = Convert.ToInt32(reader["TotalBonus"]);
                        bonusCardDTO.UserId = Convert.ToInt32(reader["user_id"]);
                    }
                    return bonusCardDTO;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Bonus Card get ERR", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public void UpdateBonusCard(BonusCardDTO bonusCardDTO)
        {
            try
            {

                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "UPDATE [BonusCard] Set TotalBonus = @points " +
                     " Where User_Id = @user";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;
                    sqlHandler.Parameters.Add("@points", System.Data.SqlDbType.Int).Value = bonusCardDTO.TotalBonusPoints;
                    sqlHandler.Parameters.Add("@user", System.Data.SqlDbType.Int).Value = bonusCardDTO.UserId;

                    sqlHandler.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add bonus card sorry", ex);
            }
            finally
            {
                DBConnection.connection.Close();

            }
        }

    }

    

}

