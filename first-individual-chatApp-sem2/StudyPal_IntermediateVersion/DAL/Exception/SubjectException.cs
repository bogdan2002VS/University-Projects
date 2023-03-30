using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Exception
{
    public class SubjectException : System.Exception
    {
        public SubjectException(string message, System.Exception inner) : base(message, inner) { }
    }
}
