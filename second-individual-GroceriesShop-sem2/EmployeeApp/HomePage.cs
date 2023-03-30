using DAL.Repository;
using Logic.Order.Model;
using Logic.Order.Service;
using Logic.Product.Service;
using Logic.Products.Model;
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
    public partial class HomePage : Form
    {
        IProductService productService;
        IOrderService orderService;
        public HomePage()
        {
            try
            {
                InitializeComponent();
                productService = new ProductService(new ProductRepository());
                orderService = new OrderService(new OrderRepository());
                RefreshListBox();
                RefreshOrderListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not initialize Home Page");
            }

        }
        public void RefreshOrderListBox()
        {
            try
            {
                lbxOrders.Items.Clear();
                lbxOrders.Update();

                foreach (var o in orderService.GetAllOrders())
                {
                    lbxOrders.Items.Add(o);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! You could not refresh the products list");
            }
            
        }

        public void RefreshListBox()
        {
            try
            {
                lbxProducts.Items.Clear();
                lbxProducts.Update();

                foreach (ProductModel p in productService.GetAllProducts())
                {
                    lbxProducts.Items.Add(p);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ups! You could not refresh the products list");
            }
           
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ProductModel selectedProduct = (ProductModel)lbxProducts.SelectedItem;
                ProductCRUD productCRUD = new ProductCRUD(selectedProduct, this);
                productCRUD.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ups! You cant see the product informatin at the moment");
            }
            



        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {

                AddProductForm addProductForm = new AddProductForm(this);
                addProductForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! The app could not open the add product form try again later");

            }
        }

        private void lbOrders_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OrderModel selectedOrder = (OrderModel)lbxOrders.SelectedItem;
                UpdateStatusForm changeOrderStatusForm = new UpdateStatusForm(selectedOrder, this);
                changeOrderStatusForm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ups! You cant change order status at the moment");
            }
            
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
