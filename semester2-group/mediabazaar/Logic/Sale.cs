using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Logic
{
    public class Sale
    {
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public Employee Seller { get; set; }
        public Product Prod { get; set; }
        public int AmountSold { get; set; }

        public Sale(int saleID, DateTime saleDate, Employee seller, Product product, int amountSold)
        {
            SaleID = saleID;
            SaleDate = saleDate;
            Seller = seller;
            Prod = product;
            AmountSold = amountSold;
        }

        public string[] GetData()
        {
            return new string[]
            {
                this.SaleID.ToString(),
                this.SaleDate.ToString("G"),
                this.Seller.Id.ToString(),
                this.Prod.Id.ToString(),
                this.Prod.ProductName.ToString(),
                this.AmountSold.ToString()
            };
        }
    }
}
