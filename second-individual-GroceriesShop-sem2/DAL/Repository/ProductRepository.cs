using System.Data.SqlClient;
using DAL.DTO;
using DAL.Config;


namespace DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProductToCatalog(ProductDTO productDTO)
        {
            try
            {
                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "INSERT INTO Product(name, description, price, categoryid, image, unit) " +
                    "values(@nam, @dsc, @prc, @ctg, @img, @unit)";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;
                    sqlHandler.Parameters.Add("@nam", System.Data.SqlDbType.VarChar).Value = productDTO.Name;
                    sqlHandler.Parameters.Add("@dsc", System.Data.SqlDbType.VarChar).Value = productDTO.Description;
                    sqlHandler.Parameters.Add("@prc", System.Data.SqlDbType.Money).Value = productDTO.Price;
                    sqlHandler.Parameters.Add("@ctg", System.Data.SqlDbType.Int).Value = productDTO.CategoryID;
                    sqlHandler.Parameters.Add("@img", System.Data.SqlDbType.Image).Value = productDTO.Image;
                    sqlHandler.Parameters.Add("@unit", System.Data.SqlDbType.VarChar).Value = productDTO.Unit;


                    var reader = sqlHandler.ExecuteReader();
                    Console.WriteLine("item added");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add product", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public List<ProductDTO> GetAllProducts()
        {
            ProductDTO productDTO;
            List<ProductDTO> productDTOS = new List<ProductDTO>();


            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = "SELECT ID, Name, Description, Price, CategoryID, Unit, Image  FROM Product ";
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;

                var reader = sqlHandler.ExecuteReader();

                while (reader.Read())
                {
                    productDTO = new ProductDTO();
                    productDTO.ProductID = Convert.ToInt32(reader["id"]);
                    productDTO.Price = Convert.ToDouble(reader["price"]);
                    productDTO.Name = reader["name"].ToString();
                    productDTO.Image = (byte[])reader["image"];
                    productDTO.Description = reader["description"].ToString();
                    productDTO.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                    productDTO.Unit = reader["unit"].ToString();
                    productDTOS.Add(productDTO);

                }
                Console.WriteLine("Product read OK");
                return productDTOS;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Failed to get all the products", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public List<ProductDTO> GetProductsBySubcategoryID(int subCategoryId)
        {
            ProductDTO productDTO;
            List<ProductDTO> productDTOS = new List<ProductDTO>();

            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = $"SELECT ID, Name, Description, Price, Image, Unit  FROM Product WHERE CategoryID = @CategoryID ";
                sqlHandler.Parameters.AddWithValue("@CategoryID", subCategoryId);
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;

                var reader = sqlHandler.ExecuteReader();

                while (reader.Read())
                {
                    productDTO = new ProductDTO();
                    productDTO.ProductID = Convert.ToInt32(reader["ID"]);
                    productDTO.Price = Convert.ToDouble(reader["price"]);
                    productDTO.Name = reader["name"].ToString();
                    productDTO.Description = reader["description"].ToString();
                    productDTO.Image = (byte[])reader["image"];
                    productDTO.Unit = reader["unit"].ToString();
                    productDTOS.Add(productDTO);

                }
                return productDTOS;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Failed to get order products by subcategoryID", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public ProductDTO GetProductById(int productId)
        {
            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = $"SELECT ID, Name, Description, Price, Image  FROM Product WHERE ID = @productByID ";
                sqlHandler.Parameters.AddWithValue("@productByID", productId);
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;

                var reader = sqlHandler.ExecuteReader();

                if (reader.Read())
                {
                    var productDTO = new ProductDTO();
                    productDTO.ProductID = Convert.ToInt32(reader["ID"]);
                    productDTO.Price = Convert.ToDouble(reader["price"]);
                    productDTO.Name = reader["name"].ToString();
                    productDTO.Description = reader["description"].ToString();
                    productDTO.Image = (byte[])reader["image"];
                    return productDTO;
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Could not read product", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }
        public void UpdateProduct(ProductDTO productDTO)
        {

            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = $"UPDATE Product SET Name = @pn, Description = @dc, Price = @pr, Unit = @u, CategoryID = @ct, Image = @im WHERE ID = @updateId";
                sqlHandler.Parameters.AddWithValue("@updateId", productDTO.ProductID);
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;
                sqlHandler.Parameters.AddWithValue("@pn", productDTO.Name);
                sqlHandler.Parameters.AddWithValue("@dc", productDTO.Description);
                sqlHandler.Parameters.AddWithValue("@pr", productDTO.Price);
                sqlHandler.Parameters.AddWithValue("@ct", productDTO.CategoryID);
                sqlHandler.Parameters.AddWithValue("@im", productDTO.Image);
                sqlHandler.Parameters.AddWithValue("@u", productDTO.Unit);
                sqlHandler.Parameters.AddWithValue("@productId", productDTO.ProductID);

                sqlHandler.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error updating product", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        public void DeleteProduct(int productId)
        {


            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = $"DELETE FROM Product WHERE ID = @productId";
                sqlHandler.Parameters.AddWithValue("@productId", productId);
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;


                sqlHandler.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Failed to get  delete product", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

    }
}

