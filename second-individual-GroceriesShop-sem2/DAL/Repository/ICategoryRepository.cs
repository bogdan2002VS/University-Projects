using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL.Repository
{
    public interface ICategoryRepository
    {
        public List<CategoryDTO> GetAllCategories();
        public List<CategoryDTO> GetRootCategories();
        public List<CategoryDTO> GetParentSubCategories(int parentId);
    }
}
