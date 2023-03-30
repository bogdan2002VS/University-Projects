using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IOrderRepository
    {
        public int CreateOrder(OrderDTO orderDTO);

        public List<OrderDTO> GetOrdersByCustomerID(int customerId);

        public OrderDTO GetOrderByOrderID(int orderId);

        public List<OrderDTO> GetAllOrders();

        public void UpdateOrderStatusByID(OrderDTO orderDTO);
    }
}
