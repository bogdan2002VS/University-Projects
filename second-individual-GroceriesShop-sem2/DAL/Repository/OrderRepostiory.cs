using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.DTO;
using DAL.Config;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Xml.Linq;

namespace DAL.Repository
{
    public class OrderRepository : IOrderRepository
    {

        public int CreateOrder(OrderDTO orderDTO)
        {
            try
            {
                orderDTO.DeliveryAddress.ID = AddOrderAddress(orderDTO.DeliveryAddress);
                int orderID = -1;
                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "INSERT INTO [Order] (DeliveryAddressID,CustomerID,OrderStatus,PaymentType,Total, EarnedBonusPoints, UsedBonusPoints, Created_at ) OUTPUT inserted.ID " +
                    "Values (@da, @ci, @os, @pt, @tt, @ep, @up ,@ca)";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;
                    sqlHandler.Parameters.Add("@da", System.Data.SqlDbType.Int).Value = orderDTO.DeliveryAddress.ID;
                    sqlHandler.Parameters.Add("@ci", System.Data.SqlDbType.Int).Value = orderDTO.CustomerID;
                    sqlHandler.Parameters.Add("@os", System.Data.SqlDbType.VarChar).Value = orderDTO.OrderStatus;
                    sqlHandler.Parameters.Add("@pt", System.Data.SqlDbType.VarChar).Value = orderDTO.PaymentType;
                    sqlHandler.Parameters.Add("@tt", System.Data.SqlDbType.Money).Value = orderDTO.Total;
                    sqlHandler.Parameters.Add("@ca", System.Data.SqlDbType.DateTime).Value = orderDTO.Created_at;
                    sqlHandler.Parameters.Add("@ep", System.Data.SqlDbType.Int).Value = orderDTO.BonusPointsEarned;
                    sqlHandler.Parameters.Add("@up", System.Data.SqlDbType.Int).Value = orderDTO.BonusPointsUsed;

                    var reader = sqlHandler.ExecuteReader();
                    if (reader.Read())
                    {
                        orderID = Convert.ToInt32(reader["ID"]);
                    }

                    orderDTO.orderItemDTOs.ForEach(orderItem => orderItem.Order_ID = orderID);
                    DBConnection.connection.Close();

                    AddOrderItems(orderDTO.orderItemDTOs);

                    return orderID;

                }

            }
            catch (Exception ex)
            {
                DBConnection.connection.Close();

                throw new Exception("Failed to make order", ex);
            }

        }



        private void AddOrderItems(List<OrderItemDTO> orderItems)
        {
            try
            {
                int orderID = -1;
                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "INSERT INTO OrderItems (Order_id,Product_id,Quantity) " +
                    "values(@oi, @pi, @qa)";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;

                    foreach (var orderItem in orderItems)
                    {
                        sqlHandler.Parameters.Clear();
                        sqlHandler.Parameters.Add("oi", System.Data.SqlDbType.Int).Value = orderItem.Order_ID;
                        sqlHandler.Parameters.Add("pi", System.Data.SqlDbType.Int).Value = orderItem.Product_ID;
                        sqlHandler.Parameters.Add("qa", System.Data.SqlDbType.Int).Value = orderItem.Quantity;
                        sqlHandler.ExecuteNonQuery();


                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add order items", ex);
            }
            finally
            {
                DBConnection.connection.Close();

            }
        }

        private int AddOrderAddress(AddressDTO addressDTO)
        {
            try
            {

                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "INSERT INTO Address (StreetName, HouseNo, City, Zip) OUTPUT inserted.ID " +
                    " values(@str, @no, @city, @zip)";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;


                    sqlHandler.Parameters.Add("str", System.Data.SqlDbType.VarChar).Value = addressDTO.StreeName;
                    sqlHandler.Parameters.Add("no", System.Data.SqlDbType.VarChar).Value = addressDTO.HouseNo;
                    sqlHandler.Parameters.Add("city", System.Data.SqlDbType.VarChar).Value = addressDTO.City;
                    sqlHandler.Parameters.Add("zip", System.Data.SqlDbType.VarChar).Value = addressDTO.ZipCode;


                    var reader = sqlHandler.ExecuteReader();
                    reader.Read();
                    return Convert.ToInt32(reader["ID"]);

                }

            }
            catch (Exception ex)
            {
                throw new Exception(" Failed to add address", ex);
            }
            finally
            {
                DBConnection.connection.Close();

            }

        }

        public List<OrderDTO> GetOrdersByCustomerID(int customerId)
        {
            OrderDTO orderDTO;
            List<OrderDTO> orderDTOS = new List<OrderDTO>();

            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = $"SELECT Ord.ID, Ord.DeliveryAddressID , Adrs.StreetName, Adrs.HouseNo, Adrs.City, Adrs.Zip, OrderStatus, PaymentType, Total  FROM [Order] AS Ord " +
                    $" INNER JOIN [Address] AS Adrs ON Adrs.ID = Ord.DeliveryAddressID WHERE CustomerID = @CustomerID";
                sqlHandler.Parameters.AddWithValue("@CustomerID", customerId);
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;

                var reader = sqlHandler.ExecuteReader();

                while (reader.Read())
                {
                    orderDTO = new OrderDTO();
                    orderDTO.DeliveryAddress = new AddressDTO()
                    {
                        ID = Convert.ToInt32(reader["DeliveryAddressID"]),
                        StreeName = reader["StreetName"].ToString(),
                        HouseNo = Convert.ToInt32(reader["HouseNo"]),
                        City = reader["City"].ToString(),
                        ZipCode = reader["Zip"].ToString()
                    };
                    orderDTO.OrderStatus = reader["orderstatus"].ToString();
                    orderDTO.PaymentType = reader["paymenttype"].ToString();
                    orderDTO.Total = Convert.ToDouble(reader["total"]);
                    orderDTO.ID = Convert.ToInt32(reader["id"]);
                    orderDTOS.Add(orderDTO);

                }
                return orderDTOS;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("failed to get orders", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

        private List<OrderItemDTO> GetOrdersItemsByOrderID(int orderId)
        {
            OrderItemDTO orderDTO;
            List<OrderItemDTO> orderItemDTOs = new List<OrderItemDTO>();
            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = $"SELECT Product_id, Name, Price, Quantity  FROM [OrderItems] AS ORD " +
                    $" INNER JOIN PRODUCT AS PRD ON ORD.Product_id = PRD.ID WHERE Order_id = @Order_id ";
                sqlHandler.Parameters.AddWithValue("@Order_id", orderId);

                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;

                var reader = sqlHandler.ExecuteReader();

                while (reader.Read())
                {
                    orderDTO = new OrderItemDTO();
                    orderDTO.Product_ID = Convert.ToInt32(reader["Product_ID"]);
                    orderDTO.Quantity = Convert.ToInt32(reader["Quantity"]);
                    orderDTO.ProductName = reader["Name"].ToString();
                    orderDTO.UnitPrice = Convert.ToDouble(reader["Price"]);
                    orderItemDTOs.Add(orderDTO);

                }
                return orderItemDTOs;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Failed to get order items by orderId", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }
        }

         public OrderDTO GetOrderByOrderID(int orderId)
        {
            var orderDTO = new OrderDTO();
            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = $"SELECT Ord.ID, CustomerID, Usr.Name, Ord.DeliveryAddressID , Adrs.StreetName, Adrs.HouseNo, Adrs.City, Adrs.Zip, OrderStatus, PaymentType, Total, EarnedBonusPoints, UsedBonusPoints,  created_at  FROM [Order] AS Ord " +
                    $" INNER JOIN [Address] AS Adrs ON Adrs.ID = Ord.DeliveryAddressID " +
                    $" INNER JOIN [Users] as Usr ON Usr.ID = Ord.CustomerID " +
                    $" WHERE Ord.ID = @orderid";

                sqlHandler.Parameters.AddWithValue("@orderid", orderId);

                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;

                var reader = sqlHandler.ExecuteReader();

                if (reader.Read())
                {
                    orderDTO = new OrderDTO();
                    orderDTO.CustomerID = Convert.ToInt32(reader["customerID"]);
                    orderDTO.CustomerName = reader["Name"].ToString();

                    orderDTO.DeliveryAddress = new AddressDTO()
                    {
                        ID = Convert.ToInt32(reader["DeliveryAddressID"]),
                        StreeName = reader["StreetName"].ToString(),
                        HouseNo = Convert.ToInt32(reader["HouseNo"]),
                        City = reader["City"].ToString(),
                        ZipCode = reader["Zip"].ToString()
                    };
                    orderDTO.OrderStatus = reader["orderstatus"].ToString();
                    orderDTO.PaymentType = reader["paymenttype"].ToString();
                    orderDTO.Total = Convert.ToDouble(reader["total"]);
                    orderDTO.ID = Convert.ToInt32(reader["id"]);
                    orderDTO.BonusPointsEarned = Convert.ToInt32(reader["EarnedBonusPoints"]);
                    orderDTO.BonusPointsUsed = Convert.ToInt32(reader["UsedBonusPoints"]);
                    orderDTO.Created_at = Convert.ToDateTime(reader["created_at"]);

                    DBConnection.connection.Close();
                    orderDTO.orderItemDTOs = GetOrdersItemsByOrderID(orderDTO.ID);
                }

                return orderDTO;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("failed to get order by Id", ex);
            }

        }

        public List<OrderDTO> GetAllOrders()
        {
            OrderDTO orderDTO;
            List<OrderDTO> orderDTOS = new List<OrderDTO>();

            try
            {
                DBConnection.connection.Open();
                SqlCommand sqlHandler = new SqlCommand();

                sqlHandler.CommandText = $"SELECT Ord.ID as OrderID , Ord.DeliveryAddressID , Adrs.StreetName, Adrs.HouseNo, Adrs.City, Adrs.Zip, Usr.ID as UserID,Usr.Name as CustomerName, OrderStatus, PaymentType, Total , created_at FROM [Order] AS Ord  " +
                    $" INNER JOIN [Address] AS Adrs ON Adrs.ID = Ord.DeliveryAddressID  INNER JOIN [Users] as Usr  on Usr.ID = Ord.CustomerID ";
                sqlHandler.CommandType = System.Data.CommandType.Text;
                sqlHandler.Connection = DBConnection.connection;

                var reader = sqlHandler.ExecuteReader();

                while (reader.Read())
                {
                    orderDTO = new OrderDTO();
                    orderDTO.DeliveryAddress = new AddressDTO()
                    {
                        ID = Convert.ToInt32(reader["DeliveryAddressID"]),
                        StreeName = reader["StreetName"].ToString(),
                        HouseNo = Convert.ToInt32(reader["HouseNo"]),
                        City = reader["City"].ToString(),
                        ZipCode = reader["Zip"].ToString()
                    };
                    orderDTO.CustomerID = Convert.ToInt32(reader["UserID"].ToString());
                    orderDTO.CustomerName = reader["customername"].ToString();
                    orderDTO.OrderStatus = reader["orderstatus"].ToString();
                    orderDTO.PaymentType = reader["paymenttype"].ToString();
                    orderDTO.Total = Convert.ToDouble(reader["total"]);
                    orderDTO.ID = Convert.ToInt32(reader["OrderID"]);
                    orderDTO.Created_at = Convert.ToDateTime(reader["created_at"]);
                    orderDTOS.Add(orderDTO);

                }
                return orderDTOS;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("failed to get orders", ex);
            }
            finally
            {
                DBConnection.connection.Close();
            }

        }

        public void UpdateOrderStatusByID(OrderDTO orderDTO)
        {
            try
            {

                DBConnection.connection.Open();
                using (SqlCommand sqlHandler = new SqlCommand())
                {
                    sqlHandler.CommandText = "UPDATE [Order] Set OrderStatus = @st " +
                     " Where ID = @id";
                    sqlHandler.CommandType = System.Data.CommandType.Text;
                    sqlHandler.Connection = DBConnection.connection;
                    sqlHandler.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = orderDTO.ID;
                    sqlHandler.Parameters.Add("@st", System.Data.SqlDbType.VarChar).Value = orderDTO.OrderStatus;

                    sqlHandler.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add update order", ex);
            }
            finally
            {
                DBConnection.connection.Close();

            }
        }
    }

}
