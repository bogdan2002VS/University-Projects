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
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {

        }

        public bool UpdateProduct(ProductDTO p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"UPDATE Products SET name=@productName, amount=@amount, price=@price, productState=@productState, barcode=@barcode, minStock=@minStock WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@productName", p.ProductName);
                    cmd.Parameters.AddWithValue("@amount", p.Amount);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.Parameters.AddWithValue("@productState", p.ProductState);
                    cmd.Parameters.AddWithValue("@barcode", p.Barcode);
                    cmd.Parameters.AddWithValue("@minStock", p.MinStock);
                    cmd.Parameters.AddWithValue("@id", p.Id);

                    int affectedRows = cmd.ExecuteNonQuery();

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

        public bool AddProduct(ProductDTO p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "INSERT INTO Products(name, amount, price, productState, barcode, minStock) VALUES (@productName, @amount, @price, @productState, @barcode, @minStock)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@productName", p.ProductName);
                    cmd.Parameters.AddWithValue("@amount", p.Amount);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.Parameters.AddWithValue("@productState", p.ProductState);
                    cmd.Parameters.AddWithValue("@barcode", p.Barcode);
                    cmd.Parameters.AddWithValue("@minStock", p.MinStock);

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


        public ProductDTO[] GetProducts()
        {
            ProductDTO product = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT * FROM Products";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();


                    SqlDataReader dr = cmd.ExecuteReader();

                    List<ProductDTO> productDTOs = new List<ProductDTO>();
                    while (dr.Read())
                    {

                        //ProductDTO product = new ProductDTO(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]),
                        //    Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]),
                        //    dr[5].ToString(), Convert.ToInt32(dr[6]));

                        product = new ProductDTO();
                        product.Id = Convert.ToInt32(dr["id"]);
                        product.ProductName = dr["name"].ToString();
                        product.Price = Convert.ToDouble(dr["price"]);
                        product.Amount = Convert.ToInt32(dr["amount"]);
                        product.MinStock = Convert.ToInt32(dr["minStock"]);
                        product.Barcode = dr["barcode"].ToString();
                        product.ProductState = Convert.ToInt32(dr["ProductState"]);

                        productDTOs.Add(product);
                    }
                    return productDTOs.ToArray();

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong");
            }
            return null;
        }

        public ProductDTO GetProductByBarcode(string barcode)
        {
            ProductDTO product = null;
            try
            {

                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT * FROM Products where barcode = @barcode";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@barcode", barcode.Substring(0, barcode.Length - 1));

                    var dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        product = new ProductDTO();
                        product.Id = Convert.ToInt32(dr["id"]);
                        product.productName = dr["name"].ToString();
                        product.price = Convert.ToDouble(dr["price"]);


                    }
                    return product;

                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Something went wrong");
            }
            return null;
        }

        public ProductDTO GetProductById(int id)
        {
            ProductDTO product = null;
            try
            {

                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT * FROM Products  WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);

                    var dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        product = new ProductDTO();
                        product.Id = Convert.ToInt32(dr["id"]);
                        product.productName = dr["name"].ToString();
                        product.price = Convert.ToDouble(dr["price"]);
                        product.amount  = Convert.ToInt32(dr["amount"]);
                        product.MinStock = Convert.ToInt32(dr["minStock"]);


                    }
                    return product;

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ups could not Get the product");
            }
            return null;
        }

        public bool SellProduct(int id, int sellingAmount, int sellerID)
        {
            int currentAmountInStock = GetAmountInStock(id);
            int newQuantity = currentAmountInStock - sellingAmount;

            if (sellingAmount > currentAmountInStock)
            {
                throw new Exception($"Entry for {sellingAmount} of item #{id} was not sold due to insufficient storage quantity");
            }
            using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
            {


                string query = "UPDATE Products SET amount = @newAmount WHERE id = @productId;" +
                           "INSERT INTO Sale (saleDate,sellerID,productID,amount) VALUES (@saleDate,@sellerID,@productId,@amount);";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@newAmount", newQuantity.ToString());
                cmd.Parameters.AddWithValue("@productId", id.ToString());

                cmd.Parameters.AddWithValue("@saleDate", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@sellerID", sellerID);
                cmd.Parameters.AddWithValue("@amount", sellingAmount);
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows != 1)
                {
                    conn.Close();
                    ProductDTO p = GetProductById(id);
                    int newAmountInStock = p.amount;
                    int minimumStock = p.MinStock;

                    if (newAmountInStock < minimumStock)
                    {
                        int amountToRestock = (minimumStock - newAmountInStock) + minimumStock;
                        CreateRestockRequest(id, amountToRestock);
                    }
                    return true;
                }

            }
            return false;
        }

        public int GetAmountInStock(int id)
        {

            int result = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string query = "select amount from Products where id = @prodId";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@prodId", id);
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }
        public bool RemoveProduct(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"DELETE FROM Products WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);

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

        public bool CreateRestockRequest(int productID, int amountToRestock)
        {

            try
            {

                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "INSERT INTO RestockRequest (dateCreated,productId,amount) VALUES (@dateCreated,@productId,@amount)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@dateCreated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@productId", productID);
                    cmd.Parameters.AddWithValue("@amount", amountToRestock);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        return true;
                    }
                }
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Could to process request",ex);
            }
        }



    }
}
