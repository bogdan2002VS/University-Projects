using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Config
{
    public class DBConnection
    {
        public static string _connectionstring = "Server=mssqlstud.fhict.local;Database=dbi489732_onlineshop;User Id=dbi489732_onlineshop;Password=1234";
        public static SqlConnection connection = new SqlConnection(_connectionstring);

    }
}
