using Logic.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Product.Service
{
    public interface ICategoryService
    {
        public List<CategoryModel> GetAllCategories();
        public List<CategoryModel> GetRootCategories();
        public List<CategoryModel> GetSubCategoriesByParentId(int parentId);
    }
}
