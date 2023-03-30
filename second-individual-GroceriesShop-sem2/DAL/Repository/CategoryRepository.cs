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
    public class CategoryRepository : ICategoryRepository
    {
        public List<CategoryDTO> GetAllCategories()
        {
            CategoryDTO? categoryDTO = null;
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            try
            {
                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "SELECT ID, Name, ParentID FROM Category";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;
                    var reader = sqlHandler.ExecuteReader();
                    while (reader.Read())
                    {
                        categoryDTO = new CategoryDTO();
                        categoryDTO.ID = Convert.ToInt32(reader["ID"]);
                        categoryDTO.Name = reader["Name"].ToString();
                        categoryDTO.ParentID = reader["ParentID"] is DBNull ? -1 : Convert.ToInt32(reader["ParentID"]);
                        categoryDTOs.Add(categoryDTO);
                    }
                }
                return categoryDTOs;

            }
            catch (Exception ex)
            {
                throw new Exception("Ups failed to load categories", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public List<CategoryDTO> GetRootCategories()
        {
            CategoryDTO? categoryDTO = null;
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            try
            {
                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "SELECT ID, Name, ParentID, Image FROM Category WHERE ParentID is null";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;
                    var reader = sqlHandler.ExecuteReader();
                    while (reader.Read())
                    {
                        categoryDTO = new CategoryDTO();
                        categoryDTO.ID = Convert.ToInt32(reader["ID"]);
                        categoryDTO.Name = reader["Name"].ToString();
                        categoryDTO.ParentID = reader["ParentID"] is DBNull ? -1 : Convert.ToInt32(reader["ParentID"]);
                        categoryDTO.Image = reader["Image"].ToString(); ;

                        categoryDTOs.Add(categoryDTO);
                    }
                }
                return categoryDTOs;

            }
            catch (Exception ex)
            {
                throw new Exception("Ups failed to load root categories", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }

        }

        public List<CategoryDTO> GetParentSubCategories(int parentId)
        {
            CategoryDTO? categoryDTO = null;
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            try
            {
                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = $"SELECT ID, Name, ParentID, Image FROM Category WHERE ParentID = @ParentID ";
                    sqlHandler.Parameters.AddWithValue("@ParentID", parentId);
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;
                    var reader = sqlHandler.ExecuteReader();
                    while (reader.Read())
                    {
                        categoryDTO = new CategoryDTO();
                        categoryDTO.ID = Convert.ToInt32(reader["ID"]);
                        categoryDTO.Name = reader["Name"].ToString();
                        categoryDTO.ParentID = reader["ParentID"] is DBNull ? -1 : Convert.ToInt32(reader["ParentID"]);
                        categoryDTO.Image = reader["Image"].ToString(); ;

                        categoryDTOs.Add(categoryDTO);
                    }
                }
                return categoryDTOs;

            }
            catch (Exception ex)
            {
                throw new Exception("Ups failed to load subcategories", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }

        }

    }
}
