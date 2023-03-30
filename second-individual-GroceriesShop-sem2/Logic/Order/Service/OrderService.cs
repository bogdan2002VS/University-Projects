using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Order.Model;
using Logic.Account.Model;
using DAL.Repository;
using DAL.DTO;
using Logic.Model;

namespace Logic.Order.Service
{
    public class OrderService : IOrderService
    {
        IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public int CreateOrder(OrderModel order)
        {
            try
            {
                var orderDTO = new OrderDTO();
                //add address
                AddAddressToDTO(order, orderDTO);
                //add items
                AddItemsToDTO(order, orderDTO);
                //add bonus discount
                orderDTO.Total = order.ShoppingCart.TotalPrice;
                orderDTO.BonusPointsEarned = Convert.ToInt32(orderDTO.Total);
                orderDTO.BonusPointsUsed = order.ShoppingCart.BonusCard.BonusPointsToApply;
                //add rest
                orderDTO.CustomerID = order.UserModel.ID;
                orderDTO.OrderStatus = "Pending";
                orderDTO.PaymentType = order.PaymentOption.ToString();
                orderDTO.Created_at = DateTime.Now;
                return orderRepository.CreateOrder(orderDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not perform Create Order Operation!", ex);
            }

        }

        public List<OrderModel> GetOrdersByCustomerID(int customerId)
        {
            try
            {
                List<OrderModel> orderModels = new List<OrderModel>();

                foreach (var orderDTO in orderRepository.GetOrdersByCustomerID(customerId))
                {
                    orderModels.Add(new OrderModel(orderDTO));
                }
                return orderModels;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not retrieve orders for customer", ex);
            }
        }

        public OrderModel GetOrderById(int orderId)
        {
            try
            {
                return new OrderModel(orderRepository.GetOrderByOrderID(orderId));
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting order by ID", ex);
            }
        }

        public List<OrderModel> GetAllOrders()
        {
            try
            {
                List<OrderModel> orderModels = new List<OrderModel>();

                foreach (var orderDTO in orderRepository.GetAllOrders())
                {
                    orderModels.Add(new OrderModel(orderDTO));
           
                }
                return orderModels;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not retrieve orders", ex);
            }
        }

        public void UpdateOrderStatusByID(OrderModel orderModel)
        {
            try
            {
                var orderDTO = new OrderDTO()
                {
                    ID = orderModel.ID,
                    OrderStatus = orderModel.OrderStatus,
                };
                orderRepository.UpdateOrderStatusByID(orderDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not update order", ex);
            }
        }

        private void AddAddressToDTO(OrderModel order, OrderDTO orderDTO)
        {
            try
            {
                orderDTO.DeliveryAddress = new AddressDTO()
                {
                    StreeName = order.DeliveryInfo.StreeName,
                    HouseNo = order.DeliveryInfo.HouseNo,
                    ZipCode = order.DeliveryInfo.ZipCode,
                    City = order.DeliveryInfo.City
                };
            }
            catch (Exception ex)
            {

                throw new Exception("Sorry could not add the adress to the dto",ex);
            }
            
        }

        private void AddItemsToDTO(OrderModel order, OrderDTO orderDTO)
        {
            try
            {
                foreach (var item in order.ShoppingCart.Items)
                {
                    var orderItemDTO = new OrderItemDTO()
                    {
                        Product_ID = item.Product.ID,
                        Quantity = item.Quantity,
                        UnitPrice = item.Product.Price
                    };
                    orderDTO.orderItemDTOs.Add(orderItemDTO);

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Sorry could not add the item to the dto", ex);
            }
            
        }

    }
}
