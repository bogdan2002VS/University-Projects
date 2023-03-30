using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class AddressDTO
    {
        public int ID { get; set; }
        public string StreeName { get; set; }
        public int HouseNo { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }
    }
}
