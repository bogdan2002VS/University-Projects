using DAL.Repository;
using Logic.Order.Model;
using Logic.Order.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class UpdateStatusForm : Form
    {
        private HomePage homePage = null;
        IOrderService orderService;
        OrderModel orderModel;
        public UpdateStatusForm(OrderModel orderModel, HomePage homePage)
        {
           
            
            try
            {
                InitializeComponent();
                orderService = new OrderService(new OrderRepository());
                tbID.Text = orderModel.ID.ToString();
                tbAdress.Text = orderModel.DeliveryInfo.ToString();
                tbCustomer.Text = orderModel.UserModel.Name;

                tbOrderStatus.Text = orderModel.OrderStatus;
                //tbCreation.Text = orderModel.OrderDate.Value.ToShortDateString();
                tbCreation.Text = orderModel.OrderDate.Value.ToString("yyyy-MM-dd");
                //inner join with user as well;
                this.homePage = homePage;
                this.orderModel = orderModel;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error initializing!");
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                orderModel.OrderStatus = tbOrderStatus.Text;
                orderService.UpdateOrderStatusByID(orderModel);
                homePage.RefreshOrderListBox();
                MessageBox.Show("Status was updated");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error updating error!");

            }
            this.Close();
        }

        private void label_subtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
