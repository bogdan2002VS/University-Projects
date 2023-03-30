using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class OrderItemDTO
    {
        public int ID { get; set; }
        
        public int Order_ID { get; set; }

        public int Product_ID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

    }
}
