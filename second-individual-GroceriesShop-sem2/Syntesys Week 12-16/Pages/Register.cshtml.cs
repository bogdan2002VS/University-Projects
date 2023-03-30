using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Logic.Model;
using Logic.Account.Service;
using DAL.Repository;

namespace Syntesys_Week_12_16.Pages
{
    public class RegisterModel : PageModel
    {
        IUserService userService = new UserService(new UserRepository());
        IBonusCardService bonusCardService = new BonusCardService(new BonusCardRepository());
        [BindProperty]
        public UserModel User { get; set; }

        public IActionResult OnPost()
        {
            return new RedirectToPageResult("/Register");
        }

        public void OnPostRegister()
        {

                try
                {
                    if (ModelState.IsValid)
                    {
                        var userId = userService.RegisterCustomer(User);
                        bonusCardService.CreateBonusCard(userId);
                        ViewData["result"] = "Your account has been registered.";
                    }

                }
                catch(Exception)
                {
                    ViewData["result"] = "There was an error trying to process your request.";
                }


        }
    }
}
