using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public byte[] Image { get; set; }
        public string Unit { get; set; }

    }
}
