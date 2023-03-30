using DAL.DTO;
using DAL.Repository;

namespace LogicTests.Order
{
    public class OrderRepositoryMock : IOrderRepository
    {
        public OrderDTO OrderDTOCreate;
        public OrderDTO OrderDTOUpdate;
        public int CreateOrder(OrderDTO orderDTO)
        {
            OrderDTOCreate = orderDTO;
            return 1;
        }

        public List<OrderDTO> GetAllOrders()
        {
            return new List<OrderDTO>()
            {
                new OrderDTO()
                {

                    ID = 1,
                    BonusPointsEarned = 100,
                    CustomerID = 12,
                    BonusPointsUsed = 23,
                    CustomerName = "Bogdan",
                    Modified_at = DateTime.MaxValue,
                    Created_at = DateTime.MinValue,
                    DeliveryAddress = new AddressDTO()
                    {
                        City = "Eindhoven",
                        HouseNo = 1,
                        ID = 1,
                        StreeName = " Straatsburglan"
                    },
                    orderItemDTOs = new List<OrderItemDTO>()
                        {
                            new OrderItemDTO()
                            {
                                ID =11,
                                Order_ID =1,
                                ProductName ="apple",
                                Product_ID = 1,
                                Quantity =19,
                                UnitPrice= 1.99,

                            }
                        },
                    OrderStatus = "DELIVEREd",
                    PaymentType = "CARD",
                    }
            };
        }

        public OrderDTO GetOrderByOrderID(int orderId)
        {
            return new OrderDTO()
            {
                ID = 1,
                BonusPointsEarned = 100,
                CustomerID = 12,
                BonusPointsUsed = 23,
                CustomerName = "Bogdan",
                Modified_at = DateTime.MaxValue,
                Created_at = DateTime.MinValue,
                DeliveryAddress = new AddressDTO()
                {
                    City = "Eindhoven",
                    HouseNo = 1,
                    ID = 1,
                    StreeName = " Straatsburglan"
                },
                orderItemDTOs = new List<OrderItemDTO>()
                    {
                        new OrderItemDTO()
                        {
                            ID =11,
                            Order_ID =1,
                            ProductName ="apple",
                            Product_ID = 1,
                            Quantity =19,
                            UnitPrice= 1.99,

                        }
                    },
                OrderStatus = "DELIVEREd",
                PaymentType = "CARD",
                Total = 100

            };
        }

        public List<OrderDTO> GetOrdersByCustomerID(int customerId)
        {
            return new List<OrderDTO>()
            {
                new OrderDTO()
                {
                    ID = 1,
                    BonusPointsEarned = 100,
                    CustomerID = 12,
                    BonusPointsUsed = 23,
                    CustomerName = "Bogdan",
                    Modified_at = DateTime.MaxValue,
                    Created_at = DateTime.MinValue,
                    DeliveryAddress = new AddressDTO()
                    {
                        City = "Eindhoven",
                        HouseNo = 1,
                        ID = 1,
                        StreeName =" Straatsburglan"
                    },
                    orderItemDTOs = new List<OrderItemDTO>()
                    {
                        new OrderItemDTO()
                        {
                            ID =11,
                            Order_ID =1,
                            ProductName ="apple",
                            Product_ID = 1,
                            Quantity =19,
                            UnitPrice= 1.99,

                        }
                    },
                    OrderStatus = "DELIVEREd",
                    PaymentType = "CARD",
                    Total = 100

                }
        };
        }

        public void UpdateOrderStatusByID(OrderDTO orderDTO)
        {
            OrderDTOUpdate = orderDTO;
        }
    }
}
