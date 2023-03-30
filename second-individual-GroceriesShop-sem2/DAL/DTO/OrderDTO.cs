using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class OrderDTO
    {
        public int ID { get; set; }

        public AddressDTO DeliveryAddress { get; set; }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string OrderStatus { get; set; }

        public string PaymentType { get; set; }

        public double Total { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Modified_at { get; set; }

        public List<OrderItemDTO> orderItemDTOs { get; set; } = new List<OrderItemDTO>();

        public int BonusPointsEarned { get; set; }

        public int BonusPointsUsed { get; set; }

    }
}
