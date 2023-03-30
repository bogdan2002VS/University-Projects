using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Product.Model
{
    public class CategoryModel
    {
        public CategoryModel()
        {
        }

        public CategoryModel(CategoryDTO categoryDTO)
        {

            ID = categoryDTO.ID;
            Name = categoryDTO.Name;
            subCategories = new List<CategoryModel>();
            Image = categoryDTO.Image;
        }


        public int ID { get; set; } = 0;
        public string Name { get; set; } = String.Empty;

        public List<CategoryModel> subCategories { get; set; }

        public string Image { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is CategoryModel)
            {
                var p = (CategoryModel)obj;
                return p.ID == this.ID && p.Name == this.Name;
                    
            }
            return false;
        }
    }
}
