using System;
using System.Data.SqlClient;
using DAL.Exception;

namespace DAL
{
    public class SQLConnect
    {
        public static string _connectionstring = "Server=mssqlstud.fhict.local;Database=dbi489732_chatdata;User Id=dbi489732_chatdata;Password=1234";
        public static SqlConnection connection = new SqlConnection(_connectionstring);

    }
}
