using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.DTO
{
    public class WarningDTO
    {
        public WarningDTO(string reson)
        {
            Reson = reson;
        }

        public WarningDTO()
        {

        }

        public string Reson { get; set; }
    }
}
