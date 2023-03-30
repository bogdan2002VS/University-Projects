using DAL.Exception;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace DAL
{
    public class QueryExecutor
    {
        private readonly string connectionstring;

        public QueryExecutor(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public QueryExecutor()
        {

        }
                
        public virtual Object Execute(string query, Func<SqlDataReader, Object> func)
        {

            try
            {
                using SqlConnection sqlConnection = new SqlConnection(SQLConnect._connectionstring);
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = query;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                return func.Invoke(reader);
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("The query can't be executed", ex);
            }
            finally { SQLConnect.connection.Close(); }
        }
    }
}
