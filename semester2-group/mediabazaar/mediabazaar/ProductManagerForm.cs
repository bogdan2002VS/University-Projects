using DataL.interfaces;
using DataL;
using Logic;
using Logic.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.ClassManagers;
using Logic.EmployeeTypes;

namespace mediabazaar
{
    public partial class ProductManagerForm : Form
    {
        IProductRepository productRepository;
        IProduct productManager; 

        private Employee employee;
        private List<Product> products;
        public ProductManagerForm(Employee employee)
        {
            InitializeComponent();

            LoadEnums();

            this.employee = employee;

            productRepository = new ProductRepository();
            productManager = new ProductManager(productRepository);
        }

        private void btnSeeProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = CreateProduct();

                bool success = productManager.AddProduct(product);

                if (success == true)
                {
                    MessageBox.Show("Product Added");
                }
                else
                {
                    MessageBox.Show("Product not Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Information inserted incorrectly");
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = productManager.RemoveProduct(products[lbxProducts.SelectedIndex].Id);
                if (success = true)
                {
                    LoadProducts();
                    MessageBox.Show("Product Removed");
                }
                else
                {
                    MessageBox.Show("Product Not Removed");
                }    
            }
            catch (Exception)
            {

                MessageBox.Show("Something Went Wrong Removing  Product");
            }
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = CreateProduct();
                product.Id = products[lbxProducts.SelectedIndex].Id;

                bool success = productManager.UpdateProduct(product);

                if (success == true)
                {
                    MessageBox.Show("Product Information Updated");
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Product Information not Updated");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Information inserted incorrectly");
            }
        }

        private void btnProductStats_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        public Product CreateProduct()
        {
            try
            {
                string name = tbxProductName.Text;
                int amount = Convert.ToInt32(tbxAmount.Text);
                double price = (double)tbxPrice.Value;
                ProductState pS = (ProductState)cbxProductStatus.SelectedIndex;
                string barcode = tbxBarcode.Text;
                int minStock = Convert.ToInt32(tbxMinStock.Text);

                Product product = new Product(name, amount, price, pS, barcode, minStock);

                return product;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Something went wrong creating product" + ex.ToString());
            }
        }

        public void LoadProducts()
        {
            lbxProducts.Items.Clear();

            products = productManager.GetProducts().ToList();
            foreach (Product p in products)
            {
                lbxProducts.Items.Add(p);
            }
        }

        public void LoadEnums()
        {
            cbxProductStatus.Items.Clear();
            foreach(ProductState productState in Enum.GetValues(typeof(ProductState)))
            {
                cbxProductStatus.Items.Add(productState.ToString());
            }

            cbxProductStatus.SelectedIndex = 0;
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbBoughtFor_Click(object sender, EventArgs e)
        {

        }

        private void tabEmployeeInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbxProducts_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int myRandomNo = rnd.Next(10000000, 99999999);
            tbxBarcode.Text = myRandomNo.ToString();
        }

        private void lvSales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProductStats_Click_1(object sender, EventArgs e)
        {
            ProductsStats productsStats = new ProductsStats();
            productsStats.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestockRequestsForm productsStats = new RestockRequestsForm();
            productsStats.Show();
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)lbxProducts.SelectedItem;
            if (selectedProduct != null)
            {
                tbxProductName.Text = selectedProduct.ProductName;
                tbxAmount.Text = selectedProduct.Amount.ToString();
                tbxBarcode.Text = selectedProduct.Barcode.ToString();
                tbxPrice.Text = selectedProduct.Price.ToString();
                tbxMinStock.Text = selectedProduct.MinStock.ToString();

                cbxProductStatus.Text = selectedProduct.ProductState.ToString();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (tbxSearch.Text != string.Empty)
            {
                lbxProducts.Items.Clear();

                string[] search = tbxSearch.Text.ToLower().Split(" ");

                List<Product> searchedProducts = productManager.SearchProduct(search);

                products = searchedProducts;

                foreach (Product product in searchedProducts)
                {
                    lbxProducts.Items.Add(product);
                }
            }
            else
            {
                LoadProducts();
            }
        }
    }
}
