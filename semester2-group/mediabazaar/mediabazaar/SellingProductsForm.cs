using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.ScannerLogic;
using Logic.ClassManagers;
using Logic.interfaces;
using DataL.interfaces;
using DataL;

namespace mediabazaar
{
    public partial class SellingProductsForm : Form
    {
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);
        IProductRepository productRepository;
        IProduct productManager;
        bool changed = false;
        Employee currentEmployee = null;
        public SellingProductsForm(Employee employee)
        {
            InitializeComponent();
            btnAddAmountToCart.Enabled = false;
            btnRemoveEntry.Enabled = false;
            tbxTotal.Text = string.Empty;
            chbxAutoAdd.Checked = true;
            autoAddToolTip.SetToolTip(chbxAutoAdd, "For scanner convenience: check if you want item to be automatically added to cart");
            this.KeyPreview = true;
            currentEmployee = employee;
            productRepository = new ProductRepository();
            productManager = new ProductManager(productRepository);
        }

        private void AddToCart(int? quantity)
        {
            int amount = 0;

            if (quantity.HasValue)
            {
                amount = quantity.Value;
            }
            else
            {
                if (nmrAddAmountToCart.Value == 0)
                {
                    return;
                }
                else
                {
                    amount = (int)nmrAddAmountToCart.Value;
                }
            }

            if (lvAllItems.SelectedItems.Count == 0) { return; }

            string[] cartItemInfo =
            {
                lvAllItems.SelectedItems[0].SubItems[0].Text,
                lvAllItems.SelectedItems[0].SubItems[1].Text,
                amount.ToString(),
                (Convert.ToDouble(lvAllItems.SelectedItems[0].SubItems[6].Text)*amount).ToString()
            };

            ListViewItem cartItem = new ListViewItem(cartItemInfo);
            cartItem.Tag = lvAllItems.SelectedItems[0].Tag;
            lvCart.Items.Add(cartItem);

            CalculateTotal();
            tbSearch.Select();
        }
        private void CalculateTotal()
        {
            double total = 0;

            for (int i = 0; i < lvCart.Items.Count; i++)
            {
                double pricePerEntry = Convert.ToDouble(lvCart.Items[i].SubItems[3].Text);
                total = total + pricePerEntry;
            }

            tbxTotal.Clear();
            tbxTotal.Text = total.ToString();
        }

        private void lvAllItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSellCart_Click(object sender, EventArgs e)
        {
            if (lvCart.Items.Count == 0) 
            { 
                return; 
            }

            for (int i = 0; i < lvCart.Items.Count; i++)
            {
                int productId = Convert.ToInt32(lvCart.Items[i].SubItems[0].Text);
                int amountToSell = Convert.ToInt32(lvCart.Items[i].SubItems[2].Text);
                try
                {
                    if (productManager.SellProduct(productId, amountToSell, currentEmployee.Id) == false)
                    {
                         MessageBox.Show("Error");
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ups there was an error, could not sell the items");
                }

            }

            lvCart.Items.Clear();
            tbxTotal.Clear();
        }
        private void SellingProductsForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
            var amount = 0;

            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
            {
                _barcode.Clear();
            }

            // record keystroke & timestamp
            _barcode.Add(e.KeyChar);
            _lastKeystroke = DateTime.Now;


            if (lvCart.Items.Count != 0)
            {
                //var idIdx = lvCart.Columns["columnID"].Index;
                //var amoundIdx = lvCart.Columns["columnAmount"].Index;

                // process barcode
                if ((e.KeyChar == 13 && _barcode.Count > 0))
                {
                    amount = amount + 1;
                    changed = false;
                    string msg = new String(_barcode.ToArray());
                    Product product = productManager.GetProductByBarcode(msg);
                    foreach (ListViewItem cartItem in lvCart.Items)
                    {
                        if (cartItem.SubItems[0].Text == product.Id.ToString())
                        {
                            cartItem.SubItems[2].Text = ((Convert.ToInt32(cartItem.SubItems[2].Text)) + 1).ToString();
                            cartItem.SubItems[3].Text = ((Convert.ToDouble(cartItem.SubItems[3].Text)) + (Convert.ToDouble(cartItem.SubItems[3].Text))).ToString();
                            changed = true;
                            break;
                        }
                        if (changed == true)
                        {
                            break;
                        }

                    }
                    if (changed == false)
                    {
                        ListViewItem item = new ListViewItem(product.Id.ToString());
                        item.SubItems.Add(product.ProductName);
                        item.SubItems.Add(amount.ToString());
                        item.SubItems.Add(product.Price.ToString());

                        lvCart.Items.Add(item);
                    }

                    _barcode.Clear();
                }

            }
            else
            {
                if ((e.KeyChar == 13 && _barcode.Count > 0))
                {
                    amount = amount + 1;
                    string msg = new String(_barcode.ToArray());
                    //MessageBox.Show(msg);
                    Product product = productManager.GetProductByBarcode(msg);

                    ListViewItem item = new ListViewItem(product.Id.ToString());
                    item.SubItems.Add(product.ProductName);
                    item.SubItems.Add(amount.ToString());
                    item.SubItems.Add(product.Price.ToString());
                    lvCart.Items.Add(item);
                    _barcode.Clear();
                }
            }
            CalculateTotal();
        }



        private void btnResetCart_Click(object sender, EventArgs e)
        {

        }
    }
}
