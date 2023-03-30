using System;
using System.Collections.Generic;
using System.Text;

namespace BUSLOGIC.Exceptions
{
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException(string message) : base(message) { }
    }
}
