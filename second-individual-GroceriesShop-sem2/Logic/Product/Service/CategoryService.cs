using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;
using DAL.Repository;
using Logic.Product.Model;
using Logic.Product.Util;

namespace Logic.Product.Service
{
    public class CategoryService : ICategoryService
    {

        ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public List<CategoryModel> GetRootCategories()
        {
            try
            {
                List<CategoryModel> rootCategories = new List<CategoryModel>();
                List<CategoryDTO> rootCategoriesDTO = categoryRepository.GetRootCategories();

                foreach (var rootCategory in rootCategoriesDTO)
                {
                    rootCategories.Add(new CategoryModel(rootCategory));
                }

                return rootCategories;
            }
            catch (Exception ex)
            {

                throw new Exception("Error getting root categories", ex);

            }


        }
        public List<CategoryModel> GetSubCategoriesByParentId(int parentId)
        {

            try
            {
                List<CategoryModel> rootsSubCategories = new List<CategoryModel>();
                List<CategoryDTO> rootsSubCategoriesDTO = categoryRepository.GetParentSubCategories(parentId);

                foreach (var rootCategory in rootsSubCategoriesDTO)
                {
                    rootsSubCategories.Add(new CategoryModel(rootCategory));
                }

                return rootsSubCategories;
            }
            catch (Exception ex)
            {

                throw new Exception("Error getting categories by parent Id", ex);
            }


        }
        public List<CategoryModel> GetAllCategories()
        {
            try
            {
                List<CategoryModel> categories = new List<CategoryModel>();
                List<CategoryDTO> categoriesDTOs = categoryRepository.GetAllCategories();

                var mapper = new CategoryTreeMapper(categoriesDTOs);
                return mapper.toAllCategoryModels();
            }
            catch (Exception ex)
            {

                throw new Exception("Error getting categories", ex);

            }


        }

    }
}
