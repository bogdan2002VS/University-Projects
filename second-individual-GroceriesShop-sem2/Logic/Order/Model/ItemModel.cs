using DAL.DTO;
using Logic.Products.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Order.Model
{
    public class ItemModel
    {
        public ItemModel()
        {

        }
        public ItemModel(OrderItemDTO orderItemDTO)
        {
            Product = new ProductModel()
            {
                ID = orderItemDTO.Product_ID,
                Name = orderItemDTO.ProductName,
                Price = orderItemDTO.UnitPrice
            };
            Quantity = orderItemDTO.Quantity;
        }

        public ProductModel Product { get; set; }

        public int Quantity { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is ItemModel)
            {
                var i = (ItemModel)obj;
                return i.Product.Equals(this.Product) && i.Quantity == this.Quantity;
                
            }
            return false;
        }
    }
}
