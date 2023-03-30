using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.Config
{
    public class DBConnection
    {
        public const string _connectionstring = "Server = mssqlstud.fhict.local; Database=dbi499359_project;User Id = dbi499359_project; Password=groupproject";
        public static SqlConnection connection = new SqlConnection(_connectionstring);

    }
}
