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

namespace mediabazaar
{
    public partial class ProductsStats : Form
    {
        private List<Sale> sales = new List<Sale>();

        public ProductsStats()
        {
            InitializeComponent();
            lblItemName.Text = string.Empty;
            cbxSort.DataSource = Enum.GetValues(typeof(SalesSort));

            cbxSort.SelectedIndex = 1;
            RefreshSales(SalesSort.DATEDESC);
        }

        private void RefreshSales(SalesSort sort)
        {
            lvSales.Items.Clear();
            try
            {
                sales = SalesService.GetAllSales(sort);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpsCould not refresh sales");
            }


            foreach (Sale s in sales)
            {
                ListViewItem lvi = new ListViewItem(s.GetData());
                lvi.Tag = s;
                lvSales.Items.Add(lvi);
            }

            tbxTotalSales.Text = lvSales.Items.Count.ToString();
            tbxTotalRevenue.Text = "\u20AC" + sales.Select(s => s.Prod.Price * s.AmountSold).Sum().ToString("0.00");
            tbxTotalItemsSold.Text = sales.Select(s => s.AmountSold).Sum().ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SalesSort sort;
            Enum.TryParse<SalesSort>(cbxSort.SelectedValue.ToString(), out sort);
            RefreshSales(sort);
        }

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalesSort sort;
            Enum.TryParse<SalesSort>(cbxSort.SelectedValue.ToString(), out sort);
            RefreshSales(sort);
        }

        private void lvSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSales.SelectedItems.Count == 0) return;

            //data for selected product
            int itemID = ((Sale)lvSales.SelectedItems[0].Tag).Prod.Id;

            lblItemName.Text = sales.Select(s => s.Prod)
                                    .FirstOrDefault(p => p.Id == itemID)
                                    .ProductName;

            tbxItemsSold.Text = sales.Where(s => s.Prod.Id == itemID)
                                     .Select(s => s.AmountSold)
                                     .Sum()
                                     .ToString();

            tbxRevenueFromItem.Text = "\u20AC" +
                                sales.Where(s => s.Prod.Id == itemID)
                                     .Select(s => s.Prod.Price * s.AmountSold)
                                     .Sum()
                                     .ToString("0.00");

            //data for selected date

            DateTime date = ((Sale)lvSales.SelectedItems[0].Tag).SaleDate.Date;

            tbxItemsSoldDate.Text = sales.Where(s => s.SaleDate.Date == date)
                                         .Select(s => s.AmountSold)
                                         .Sum()
                                         .ToString();

            tbxSalesDate.Text = sales.Count(s => s.SaleDate.Date == date).ToString();

            tbxRevenueDate.Text = "\u20AC" +
                                sales.Where(s => s.SaleDate.Date == date)
                                     .Select(s => s.Prod.Price * s.AmountSold)
                                     .Sum()
                                     .ToString("0.00");
        }

        private void ProductsStats_Load(object sender, EventArgs e)
        {

        }
    }
}
