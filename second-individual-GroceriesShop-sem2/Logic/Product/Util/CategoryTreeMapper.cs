using DAL.DTO;
using Logic.Product.Model;

namespace Logic.Product.Util
{
    public class CategoryTreeMapper
    {
        private List<CategoryDTO> categoryDTOs;

        public CategoryTreeMapper(List<CategoryDTO> categoryDTOs)
        {
            this.categoryDTOs = categoryDTOs;
        }

        public List<CategoryModel> toAllCategoryModels()
        {
            try
            {
                List<CategoryDTO> rootCategorieDTOs = categoryDTOs.Where(x => x.ParentID == -1).ToList();
                List<CategoryModel> rootCategoryModels = new List<CategoryModel>();
                foreach (var parentCategoryDTO in rootCategorieDTOs)
                {
                    var categoryModel = new CategoryModel(parentCategoryDTO);
                    rootCategoryModels.Add(categoryModel);
                }
                TraverseSubcategories(rootCategoryModels);
                return rootCategoryModels;
            }
            catch (Exception ex)
            {

                throw new Exception("Sorry could not manage the category",ex);
            }
           
        }

        private void TraverseSubcategories(List<CategoryModel> categories)
        {
            try
            {
                foreach (var categoryModel in categories)
                {
                    addSubcategories(categoryModel);
                    TraverseSubcategories(categoryModel.subCategories);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Sorry we could not traverse the subcategory",ex);
            }
           
        }

        private void addSubcategories(CategoryModel categoryModel)
        {
            try
            {
                var subCategoriesDTOs = categoryDTOs.Where(dto => dto.ParentID == categoryModel.ID).ToList();
                if (subCategoriesDTOs.Count() != 0)
                {
                    foreach (var subcategoryDTO in subCategoriesDTOs)
                    {
                        categoryModel.subCategories.Add(new CategoryModel(subcategoryDTO));

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Oops! Could not add the subcategory",ex);
            }
           
        }
    }
}
