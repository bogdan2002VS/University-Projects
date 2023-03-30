using DataL;
using DataL.interfaces;
using Logic;
using Logic.ClassManagers;
using Logic.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace mediabazaarWebsite.Pages
{
    public class changepasswordModel : PageModel
    {
        ICredentialsManager credentialsManager;
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        [Required]
        public string Password { get; set; }
        [BindProperty]
        [Required]
        public string ConfirmPassword { get; set; }

        public string ErrorMessage { get; set; }

        public changepasswordModel()
        {
            credentialsManager = new CredentialsManager(new CredentialsRepository());
        }

        public void OnGet(int id)
        {
            Id = id;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Password == ConfirmPassword)
                {
                    credentialsManager.UpdatePassword(Id, Password);
                    return RedirectToPage("/CongratsPage");
                }
                else
                {
                    ErrorMessage = "Passwords dont match";
                }
            }
            else
            {
                return RedirectToPage("/changepassword");
            }
            return Page();
        }
    }
}
