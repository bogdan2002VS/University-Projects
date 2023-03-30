using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class RestockRequest
    {
        public int RequestId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateProcessed { get; set; }
        public Product Prod { get; set; }
        public int AmountToRestock { get; set; }
        public string Status { get; set; }

        public RestockRequest(int id, DateTime dateCreated, DateTime dateProccessed, Product p, int amountToRestock, string status)
        {
            this.RequestId = id;
            this.DateCreated = dateCreated;
            this.DateProcessed = dateProccessed;
            this.Prod = p;
            this.AmountToRestock = amountToRestock;
            this.Status = status;

        }

        public string[] GetDataArray()
        {

            string[] listViewData =
            {
                RequestId.ToString(),
                DateCreated.ToString("d"),
                DateProcessed.ToString("d"),
                Prod.Id.ToString(),
                Prod.ProductName,
                Prod.Amount.ToString(),
                Prod.MinStock.ToString(),
                AmountToRestock.ToString(),
                Status
            };

            if (DateProcessed == DateTime.MinValue)
            {
                listViewData[2] = "Not processed yet";
            }

            return listViewData;
        }
    }
}
