using DAL.Repository;
using Logic.Account.Service;
using Logic.Product.Model;
using Logic.Product.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace Syntesys_Week_12_16.Pages
{
    public class CatalogueSubcategoryModel : PageModel
    {
       
        ICategoryService categoryService = new CategoryService(new CategoryRepository());
        [BindProperty]
        public List<CategoryModel>? SubCategoryModelList { get; set; }

        [BindProperty(SupportsGet = true)]
        public int ID { get; set; }
        public void OnGet()
        {
            try
            {

                SubCategoryModelList = categoryService.GetSubCategoriesByParentId(this.ID);

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "Oh snap !!! Something unexpected has occurred");
            }

  

        }
    }
}
