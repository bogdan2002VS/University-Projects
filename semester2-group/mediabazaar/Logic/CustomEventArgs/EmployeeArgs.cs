using Logic.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.CustomEventArgs
{
    public class EmployeeArgs : EventArgs
    {
        public Employee? Employee { get; set; }
    }
}
