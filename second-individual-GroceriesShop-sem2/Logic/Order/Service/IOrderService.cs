using Logic.Order.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Order.Service
{
    public interface IOrderService
    {
        public int CreateOrder(OrderModel order);

        public List<OrderModel> GetOrdersByCustomerID(int customerId);

        public OrderModel GetOrderById(int orderId);
        public List<OrderModel> GetAllOrders();

        public void UpdateOrderStatusByID(OrderModel orderModel);

    }
}
