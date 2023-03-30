using DataL.Config;
using DataL.DTO;
using DataL.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductService
    {
        //public static Product GetProduct(int id)
        //{
        //    Product foundProduct = null;

        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
        //        {
        //            string query = $"SELECT * FROM Product WHERE productId = @id";

        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@id", id);
        //            conn.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                int productID = reader.GetInt32("productID");
        //                string productName = reader.GetString("productName");
        //                string productEAN = reader.GetString("productEan");
        //                int deptID = reader.GetInt32("departmentId");
        //                int amountInStock = Convert.ToInt32(reader.("amountInStock"));
        //                int minStock = reader.GetInt32("minStock");
        //                double price = reader.GetDouble("price");
                        

        //                foundProduct = new Product(productID, productName, productEAN, deptID, amountInStock, minStock, price, picture);
        //            }
        //            reader.Close();
        //            return foundProduct;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        throw new Exception("Ups could not found the product");
        //    }
        //}
    }
}
