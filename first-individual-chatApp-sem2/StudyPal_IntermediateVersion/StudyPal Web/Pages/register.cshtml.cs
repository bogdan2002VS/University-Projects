using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUSLOGIC;
using System.ComponentModel.DataAnnotations;
using BUSLOGIC.Classes.UserHandler;
using DAL;

namespace Proiect_din_ala_tank.Pages
{
    public class registerModel : PageModel
    {
        [BindProperty]
        [Required]
        public string Name { get; set; }
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
      
        public string Password { get; set; }

        UserManager dal = new UserManager(new QueryExecutor(SQLConnect._connectionstring)); //make this singleton

        public IActionResult OnGet()
        {
            return Page();
        }
        
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dal.AddUser(this.Name, this.Username, this.Password);
                }
                catch (Exception)
                {
                    ModelState.AddModelError(string.Empty, "Oh snap !!! Something unexpected has occurred ");
                }
                // to do cath all exptions
                return RedirectToPage("LogIn");
            }
            return Page();

        }

    }
}
