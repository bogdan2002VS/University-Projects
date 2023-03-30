using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Exception
{
    [Serializable]
    public class DatabaseException : System.Exception
    {
        public DatabaseException(string message, System.Exception inner) : base(message, inner) { }
    }
}
