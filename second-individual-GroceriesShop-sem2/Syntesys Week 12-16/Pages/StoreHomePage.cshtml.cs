using DAL.Repository;
using Logic.Account.Service;
using Logic.Product.Model;
using Logic.Product.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Syntesys_Week_12_16.Pages
{
    public class StoreHomePageModel : PageModel
    {
        IUserService userService = new UserService(new UserRepository());
        ICategoryService categoryService = new CategoryService(new CategoryRepository());

        [BindProperty]
        public List<CategoryModel> CategoryModelList  { get; set; }

        public void OnGet()
        {  
            try
            {
                CategoryModelList = categoryService.GetRootCategories();
            }
            catch (Exception)
            {
                ViewData["Error"] = "Could not retrieve root categories";
            }
            
            
        }

    }
}
