using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataL.Config;
using DataL;
using DataL.DTO;
using Logic.ClassManagers;

namespace Logic
{
    public class SalesService
    {
        // sorry for putting everything here the dal things and the logic i was not patient enough to do that because i have a could

        EmployeeManager employeeManager = new EmployeeManager();
        public static List<Sale> GetAllSales(SalesSort sort)
        {
            List<Sale> sales = new List<Sale>();

            string query = string.Empty;

            if (sort == SalesSort.DEFAULT)
            {
                query = "SELECT Sale.ID as saleID, Sale.saleDate, Sale.amount, Employees.Id as employeeId, Products.Id as productId, Products.name as productName, Products.amount as amountInStock, Products.minStock, Products.Price   FROM Sale inner join Employees on Sale.sellerID = Employees.id inner join Products on Sale.productID = Products.Id;";
            }
            else if (sort == SalesSort.DATEDESC)
            {
                query = "SELECT Sale.ID as saleID, Sale.saleDate, Sale.amount, Employees.Id as employeeId, Products.Id as productId, Products.name as productName , Products.amount as amountInStock, Products.minStock, Products.Price FROM Sale inner join Employees on Sale.sellerID = Employees.id inner join Products on Sale.productID = Products.Id ORDER BY saleDate DESC;";
            }
            else if (sort == SalesSort.SELLERID)
            {
                query = "SELECT Sale.ID as saleID, Sale.saleDate, Sale.amount, Employees.Id as employeeId, Products.Id as productId, Products.name as productName, Products.amount as amountInStock, Products.minStock, Products.Price FROM Sale inner join Employees on Sale.sellerID = Employees.id inner join Products on Sale.productID = Products.Id ORDER BY sellerID ASC;";
            }
            else if (sort == SalesSort.PRODUCTID)
            {
                query = "SELECT Sale.ID as saleID, Sale.saleDate, Sale.amount, Employees.Id as employeeId, Products.Id as productId, Products.name as productName, Products.amount as amountInStock, Products.minStock, Products.Price FROM Sale inner join Employees on Sale.sellerID = Employees.id inner join Products on Sale.productID = Products.Id ORDER BY Sale.productID ASC;";
            }
            try
            {

                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //sale data
                        int saleID = Convert.ToInt32(reader["saleID"]);
                        DateTime saleDate = Convert.ToDateTime(reader["saleDate"]);
                        int amountSold = Convert.ToInt32(reader["amount"]);

                        //seller data
                        int empid = Convert.ToInt32(reader["employeeId"]);

                        Employee emp = new Employee();
                        emp.Id = empid;

                        //product data
                        int productID = Convert.ToInt32(reader["productId"]);
                        string productName = reader["productName"].ToString();
                        int amountInStock = Convert.ToInt32(reader["amountInStock"]);
                        int minStock = Convert.ToInt32(reader["minStock"]);
                        double price = Convert.ToDouble(reader["price"]);

                        Product prod = new Product(productID, productName, amountInStock, minStock, price);

                        Sale sale = new Sale(saleID, saleDate, emp, prod, amountSold);
                        sales.Add(sale);



                    }
                    reader.Close();
                    return sales;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Could not load salesss");
            }
            return sales;


        }

        public static bool AcceptOrDenyRestockRequest(int id, bool accept)
        {
            DateTime currentDate = DateTime.Now;
            string dateString = $"{currentDate.Year}-{currentDate.Month}-{currentDate.Day}";
            string query;

            if (accept == true)
            {
                query = "UPDATE RestockRequest SET status = 'Accepted', dateProcessed = @newDate WHERE Id = @reqId";
            }
            else
            {
                query = "UPDATE RestockRequest SET status = 'Denied', dateProcessed = @newDate WHERE Id = @reqId";
            }

            try
            {

                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@newDate", dateString);
                    cmd.Parameters.AddWithValue("@reqId", id);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        return true;
                    }
                    return false;

                }



            }
            catch (Exception ex)
            {
                throw new Exception("Could not accept");
            }
            return false;

        }

        public static bool RestockProduct(int id, int amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            ProductRepository productRepository = new ProductRepository();
            int currentQuantity = productRepository.GetAmountInStock(id);
            int newQuantity = currentQuantity + amount;



            try
            {

                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string query = "UPDATE Products SET amount = @newAmount WHERE Id = @productId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@newAmount", newQuantity);
                    cmd.Parameters.AddWithValue("@productId", id);


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
                throw new Exception("Could not restock");
            }
            return false;

        }

        public static List<RestockRequest> GetRestockRequests()
        {
            List<RestockRequest> restockRequests = new List<RestockRequest>();


            using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
            {
                string query = "SELECT Products.Id as productId, Products.Name as productName, Products.amount as amountInStock, Products.minStock, Products.price, RestockRequest.Id as requestId, RestockRequest.dateCreated, RestockRequest.dateProcessed, RestockRequest.amount, RestockRequest.status  FROM RestockRequest inner join Products on Products.ID = RestockRequest.productId order by RestockRequest.ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader["productId"]);
                    string productName = reader["productName"].ToString();
                    int amountInStock = Convert.ToInt32(reader["amountInStock"]);
                    int minStock = Convert.ToInt32(reader["minStock"]);
                    double price = Convert.ToDouble(reader["price"]);

                    Product p = new Product(productID, productName, amountInStock, minStock, price);

                    int requestID = Convert.ToInt32(reader["requestId"]);
                    DateTime dateCreated = Convert.ToDateTime(reader["dateCreated"]);
                    DateTime dateProcessed;
                    if (!reader.IsDBNull(reader.GetOrdinal("dateProcessed")))
                    {
                        dateProcessed = reader.GetDateTime(reader.GetOrdinal("dateProcessed"));
                    }
                    else
                    {
                        dateProcessed = DateTime.MinValue;
                    }

                    int amountToRestock = Convert.ToInt32(reader["amount"]);
                    string status = reader["Status"].ToString();

                    RestockRequest rr = new RestockRequest(requestID, dateCreated, dateProcessed, p, amountToRestock, status);
                    restockRequests.Add(rr);
                }
                reader.Close();
            }

            return restockRequests;
        }
        public static bool CheckIn(string access, Employee employee)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "INSERT INTO Presencce(employeeSerial, Date, Status) VALUES (@employeeSerial, @Date, @Status)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@employeeSerial", employee.Rfid.SerialNumber);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    if (access == "AccesGranted")
                    {
                        cmd.Parameters.AddWithValue("@Status", "Present");
                    }
                    else if (access == "AccesDenied")
                    {
                        cmd.Parameters.AddWithValue("@Status", "Absent");
                    }



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
        public Employee GetEmployeeByRfid(string serial)
        {


            Employee employee = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"SELECT * From Employees WHERE RFIDSerialNumber = @serial";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@serial", serial);
                    SqlDataReader dr = cmd.ExecuteReader();

                    EmployeeDTO emp = null;

                    while (dr.Read())
                    {

                        int ID = Convert.ToInt32(dr["id"]);
                        string serialEmployee = dr["RFIDSerialNumber"].ToString();
                        int type = Convert.ToInt32(dr["type"]);
                        emp = new EmployeeDTO(ID, serialEmployee, type);
                        employee = new Employee(emp);
                        return employee;
                    }
                    return employee;

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong");
            }


        }

        public static List<DateTime> GetShiftsDate(int employeeid)
        {


            List<DateTime> shiftDates = new List<DateTime>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"Select Shifts.start From Shifts Inner join EmployeeShifts on EmployeeShifts.shiftId  = Shifts.Id  where EmployeeShifts.employeeId = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", employeeid);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        shiftDates.Add(Convert.ToDateTime(dr["start"]));
                    }

                    return shiftDates;

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong");
            }


        }

        public static List<DateTime> GetProccessDates(string employeeid)
        {


            List<DateTime> shiftDates = new List<DateTime>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = $"Select employeeSerial , date from Presencce where  employeeSerial = @employeeSerial";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@employeeSerial", employeeid);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        shiftDates.Add(Convert.ToDateTime(dr["date"]));
                    }

                    return shiftDates;

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong");
            }


        }

        public static bool Absent(Employee employee)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConnection._connectionstring))
                {
                    string sql = "INSERT INTO Absences(employeeID, Date, absenceReason,absenceDescription, ticketStatus) VALUES (@employeeID, @Date, @absenceReason,@absenceDescription, @ticket)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();

                    cmd.Parameters.AddWithValue("@employeeID", employee.Id);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.Parameters.AddWithValue("@absenceReason", "No Reason");

                    cmd.Parameters.AddWithValue("@absenceDescription", "employee didnt show to work");
                    cmd.Parameters.AddWithValue("@ticket", 0);




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

    }
}




