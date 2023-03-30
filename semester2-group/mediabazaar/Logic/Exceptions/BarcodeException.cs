﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Exceptions
{
    internal class BarcodeException : Exception
    {
        public BarcodeException()
        {
        }

        public BarcodeException(string message) : base(message)
        {
        }

        public BarcodeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
