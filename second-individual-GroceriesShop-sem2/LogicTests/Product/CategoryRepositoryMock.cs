using DAL.DTO;
using DAL.Repository;
using Logic.Product.Model;
using Logic.Product.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Product
{
    public class CategoryRepositoryMock : ICategoryRepository
    {
        public List<CategoryDTO> GetAllCategories()
        {
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>
            {
                new CategoryDTO()
                {
                    ID = 1,
                    Name = "Root1",
                    ParentID = -1,

                },
                new CategoryDTO()
                {
                    ID = 2,
                    Name = "Root2",
                    ParentID = -1,

                },
                new CategoryDTO()
                {
                    ID = 3,
                    Name = "SubategoryRoot1",
                    ParentID = 1,

                }

            };
            return categoryDTOs;
        }

        public CategoryDTO GetCategorieByID(int categoryId)
        {
            return new CategoryDTO()
            {
                ID = 1,
                Name = "Bla",
                ParentID = 23
            };
        }

        public List<CategoryDTO> GetParentSubCategories(int parentId)
        {
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>
            {
                new CategoryDTO()
                {
                    ID = 2,
                    Name = "SubCateg1",
                    ParentID = 1,

                },
                new CategoryDTO()
                {
                    ID = 3,
                    Name = "Subateg2",
                    ParentID = 1,

                }

            };
            return categoryDTOs;
        }
        public List<CategoryDTO> GetRootCategories()
        {
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>
            {
                new CategoryDTO()
                {
                    ID = 1,
                    Name = "Root1",
                    ParentID = -1,

                },
                new CategoryDTO()
                {
                    ID = 2,
                    Name = "Root2",
                    ParentID = -1,

                },

            };
            return categoryDTOs;
        }
    }
}
