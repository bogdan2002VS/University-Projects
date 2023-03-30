using System.Text.RegularExpressions;
using System;
using Logic.Exceptions;
using DataL.DTO;

namespace Logic
{
    public class Product
    {
        private int id;
        public string productName;
        public int amount;
        public int price;
        private ProductState productState;
        private string barcode;
        private int minStock;

        public int Id { get; set; }
        public string ProductName { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }


        public ProductState ProductState { get; set; }
        public string Barcode
        {
            get { return barcode; }
            set
            {
                bool success = Regex.IsMatch(value, @"\d{8}");
                if (!success)
                {
                    throw new BarcodeException("Barcode must contain only 8 digits");
                }
                else
                {
                    this.barcode = value;
                }
            }
        }
        public int MinStock { get; set; }

        //public Product(int id, decimal boughtFor, decimal soldFor,
        //string model, string brandName, string description,
        //double weight, double height, double width,
        //string category, int qtyWH, int qtySH,
        //ProductState productState, string barcode, int minStock)
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

        public Product(ProductDTO productDTO)
        {
            Id = productDTO.Id;
            ProductName = productDTO.productName;
            Price = productDTO.price;


        }
        public Product(string productName, int amount, double price, ProductState productState, string barcode, int minStock)
        {
            ProductName = productName;
            Amount = amount;
            Price = price;
            ProductState = productState;
            Barcode = barcode;
            MinStock = minStock;
        }
        public Product(int id, string name,int amountInStock, int minStock, double price)
        {
            this.Id = id;
            this.ProductName = name;

            this.Amount = amountInStock;
            this.MinStock = minStock;
            this.Price = price;
        }

        public Product()
        {

        }

        public override string ToString()
        {
            return $"ProductName: {ProductName}, Barcode: {Barcode} ";
        }
    }
}