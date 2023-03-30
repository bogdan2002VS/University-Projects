using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repository;
using Logic.Product;
using Logic.Product.Model;
using Logic.Product.Service;
using Logic.Products;
using Logic.Products.Model;

namespace EmployeeApp
{
    public partial class ProductCRUD : Form
    {
        private HomePage homePage = null;
        private IProductService productService;
        private ICategoryService categoryService;
        private ProductModel productModel = null;
        private List<CategoryModel> categories;
        private string imagePath = string.Empty;
        private byte[] image = null;
        private string rootCategoryName = "";
        private string subcategoryName = "";


        public ProductCRUD(ProductModel product, HomePage homePage)
        {

            InitializeComponent();
            try
            {
                this.homePage = homePage; //for updating the homepage on delete
                productService = new ProductService(new ProductRepository());
                categoryService = new CategoryService(new CategoryRepository());
                categories = categoryService.GetAllCategories();

                productModel = product;


                foreach (var rootCategory in categories)
                {
                    foreach (var subcateg in rootCategory.subCategories)
                    {
                        if (subcateg.ID == product.Category.ID)
                        {
                            rootCategoryName = rootCategory.Name;
                            subcategoryName = subcateg.Name;
                        }
                    }

                }
                // fill form with existing information from products
                textbox_name.Text = product.Name;
                textbox_description.Text = product.Description;
                nudPrice.Value = (decimal)product.Price;
                pbItemImage.Image = Image.FromStream(new MemoryStream(product.Image));
                combobox1.Text = rootCategoryName; //category list
                cbSCategory.Text = subcategoryName;//subcategory list
                lbUnitUpdate.Text = product.Unit;
                AddCategories();
                combobox1.SelectedItem = rootCategoryName;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Could initialise product update page");
                this.Close();
            }


        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("You whant to delete this product??","Delete", MessageBoxButtons.YesNo) ==
        System.Windows.Forms.DialogResult.No)
                {

                }
                else
                {
                    productService.DeleteProduct(productModel.ID);
                    this.Close();
                    MessageBox.Show("The product was deleted");
                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatal Error! Could not delete product!");
            }
            finally
            {
                try
                {
                    homePage.RefreshListBox();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not refresh product List!");
                    Console.Write(ex);
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();

                if (open.ShowDialog() == DialogResult.OK)
                {
                    imagePath = open.FileName.ToString();
                    pbItemImage.Image = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ops! Could not upload a photo");
            }
            
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (imagePath != string.Empty)
                {
                    FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    image = brs.ReadBytes((int)stream.Length);
                    productModel.Image = image;

                }
                CategoryModel selectedCategory;
                if (combobox1.SelectedItem != null)
                {
                    selectedCategory = categories.First(category => category.Name == combobox1.SelectedItem.ToString());
                }
                else
                {
                    selectedCategory = categories.First(category => category.Name == rootCategoryName);
                }
                //get subcategory
                string subCategoryName = null;
                if (cbSCategory.Text != null)
                {
                    subcategoryName = cbSCategory.Text;
                }
                else
                {
                    MessageBox.Show("Please select subcategory to update!");
                    return;
                }
                productModel.Category = selectedCategory.subCategories.First(subCategory => subCategory.Name == subcategoryName);

                productModel.Name = textbox_name.Text;
                productModel.Description = textbox_description.Text;
                productModel.Price = (double)nudPrice.Value;
                productModel.Unit = lbUnitUpdate.Text;

                productService.UpdateProduct(productModel);
                MessageBox.Show("Product was Updated!");
                homePage.RefreshListBox();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update product");
            }

        }

        private void AddCategories()
        {
            try
            {
                categories = categoryService.GetAllCategories();
                foreach (var category in categories)
                {
                    combobox1.Items.Add(category.Name);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sorry the system could not add the catterogries");
            }
           
        }

        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbSCategory.Items.Clear();

                var selectedCategory = categories.First(category => category.Name == combobox1.SelectedItem.ToString());

                foreach (var subcategory in selectedCategory.subCategories)
                {
                    productModel.Category = subcategory;
                    cbSCategory.Items.Add(subcategory.Name);
                }
                if (rootCategoryName != combobox1.SelectedItem.ToString())
                {
                    cbSCategory.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve subcategories!");
            }
        }
    }
}
