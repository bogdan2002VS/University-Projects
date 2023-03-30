using Logic.Product.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;
using DAL.Repository;

namespace Logic.Products.Model
{
    public class ProductModel
    {

        public ProductModel()
        {
        }

        public ProductModel(ProductDTO productDTO)
        {
            ID = productDTO.ProductID;
            Name = productDTO.Name;
            Price = productDTO.Price;
            Image = productDTO.Image;
            Unit = productDTO.Unit;
            Description = productDTO.Description;
            Category = new CategoryModel() { ID = productDTO.CategoryID };
        }

        public int ID { get; set; } = 0;

        public string Unit { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; } = 0L;
        public CategoryModel? Category { get; set; }

        public byte[] Image { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is ProductModel)
            {
                var p = (ProductModel)obj;
                return p.ID == this.ID && p.Unit == this.Unit && p.Name == this.Name 
                    && p.Description == this.Description && p.Price == this.Price;
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
