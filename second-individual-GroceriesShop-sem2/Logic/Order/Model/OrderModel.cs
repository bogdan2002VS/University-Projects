using DAL.DTO;
using Logic.Account.Model;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Order.Model
{
    public class OrderModel
    {
        public OrderModel()
        {

        }
        public OrderModel(OrderDTO orderDTO)
        {
            OrderStatus = orderDTO.OrderStatus;
            PaymentOption = Enum.Parse<PaymentOptions>(orderDTO.PaymentType);
            Total = orderDTO.Total;
            ID = orderDTO.ID;
            UserModel = new CustomerModel()
            {
                ID = orderDTO.CustomerID,
                Name = orderDTO.CustomerName
            };
            DeliveryInfo = new AddressModel()
            {
                City = orderDTO.DeliveryAddress.City,
                HouseNo = orderDTO.DeliveryAddress.HouseNo,
                StreeName = orderDTO.DeliveryAddress.StreeName,
                ZipCode = orderDTO.DeliveryAddress.ZipCode
            };
            var orderItems = new List<ItemModel>();
            foreach (var orderItemDTO in orderDTO.orderItemDTOs)
            {
                orderItems.Add(new ItemModel(orderItemDTO));
            }
            ShoppingCart = new CartModel()
            {
                Items = orderItems
            };
            OrderDate = orderDTO.Created_at;
            BonusPointsUsed = orderDTO.BonusPointsUsed;
            BonusPointsEarned = orderDTO.BonusPointsEarned;
        }

        public CartModel? ShoppingCart { get; set; }
        public CustomerModel? UserModel { get; set; }
        public AddressModel DeliveryInfo { get; set; }
        public PaymentOptions PaymentOption { get; set; }
        public DateTime? OrderDate { get; set; }

        public string? OrderStatus { get; set; }

        public int ID { get; set; }

        public double Total { get; set; }

        public int BonusPointsEarned
        {
            get; set;
        }

        public int BonusPointsUsed { get; set; }

        public override string ToString()
        {
            return $"#{this.ID}, Status:{OrderStatus}";
        }
    }
}
