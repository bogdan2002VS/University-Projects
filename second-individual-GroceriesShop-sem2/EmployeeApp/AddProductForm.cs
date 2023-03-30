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
    public partial class AddProductForm : Form
    {
        IProductService productService;
        ICategoryService categoryService;
        List<CategoryModel> categories;
        ProductModel productModel = new ProductModel();

        string imagePath = string.Empty;
        byte[] image = null;

        private HomePage homePage;

        public AddProductForm(HomePage homePage)
        {

            try
            {
                InitializeComponent();
                productService = new ProductService(new ProductRepository());
                categoryService = new CategoryService(new CategoryRepository());
                this.homePage = homePage;
                AddCategories();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not initialize");

            }

        }

        private void AddCategories()
        {
            categories = categoryService.GetAllCategories();
            foreach (var category in categories)
            {
                combobox1.Items.Add(category.Name);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                //open.Filter = "Image Files(*.jpeg, *.jpg, *.png, *.bmp)|*.jpeg, *.jpg, *.png, *.bmp";


                if (open.ShowDialog() == DialogResult.OK)
                {
                    imagePath = open.FileName.ToString();
                    pbItemImage.Image = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open image loader!");
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if(textbox_name.Text == null)
                {
                    MessageBox.Show("Please select a product name");
                    return;
                }
                if(tbUnit == null)
                {
                    MessageBox.Show("Please select a product unit");
                    return;
                }
                if (combobox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category");
                    return;
                }
                if (cbSCategory.SelectedItem == null)
                {
                    MessageBox.Show("Please select a sub-category");
                    return;
                }
                //add category and sub-category
                var selectedCategory = categories.First(category => category.Name == combobox1.SelectedItem.ToString());
                productModel.Category = selectedCategory.subCategories.First(subCategory => subCategory.Name == cbSCategory.SelectedItem.ToString());

                //add image
                if (imagePath == string.Empty)
                {
                    MessageBox.Show("Please upload an image!");
                    return;
                }
                FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                image = brs.ReadBytes((int)stream.Length);
                productModel.Image = image;

                productModel.Name = textbox_name.Text;
                productModel.Description = textbox_description.Text;
                productModel.Price = (double)nudPrice.Value;
                productModel.Unit = tbUnit.Text;

                productService.AddProductToCatalog(productModel);
                MessageBox.Show("The item whas added <3");
                homePage.RefreshListBox();
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Could not add item!");

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
            }
            catch (Exception)
            {
                MessageBox.Show("Could not retrieve subcategories!");
            }
        }

    }
}
