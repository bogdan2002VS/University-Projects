namespace DataL.DTO
{
    public class ProductDTO
    {
        private int id;
        public string productName;
        public int amount;
        public double price;
        private int productState;
        private string barcode;
        private int minStock;

        public int Id { get; set; }
        public string ProductName { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }
        public int ProductState { get; set; }
        public string Barcode { get; set; }
        public int MinStock { get; set; }

        //public ProductDTO(int id, decimal boughtFor, decimal soldFor,
        //string model, string brandName, string description,
        //double weight, double height, double width,
        //string category, int qtyWH, int qtySH,
        //int productState, string barcode, int minStock)
        //{
        //    Id = id;
        //    BoughtFor = boughtFor;
        //    SoldFor = soldFor;
        //    Model = model;
        //    BrandName = brandName;
        //    Description = description;
        //    Weight = weight;
        //    Height = height;
        //    Width = width;
        //    Category = category;
        //    QtyWH = qtyWH;
        //    QtySH = qtySH;
        //    ProductState = productState;
        //    Barcode = barcode;
        //    MinStock = minStock;
        //}

        public ProductDTO()
        {

        }

        public ProductDTO(int id, string productName, int amount, double price, int productState, string barcode, int minStock)
        {
            Id = id;
            ProductName = productName;
            Amount = amount;
            Price = price;
            ProductState = productState;
            Barcode = barcode;
            MinStock = minStock;
     
        }

        public ProductDTO(string productName, int amount, double price, int productState, string barcode, int minStock)
        {
            ProductName = productName;
            Amount = amount;
            Price = price;
            ProductState = productState;
            Barcode = barcode;
            MinStock = minStock;

        }
    }
}
