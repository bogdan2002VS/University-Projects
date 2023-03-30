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
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string Password { get; set; }

        IUserManager dal = new UserManager(new QueryExecutor(SQLConnect._connectionstring));

        public void OnGet()
        {
            Name = User.Identity.Name;
            Username = User.FindFirst("Username").Value;
            Password = User.FindFirst("Password").Value;


        }

        public IActionResult OnPost()
        {
            try
            {
                dal.UpdateUser(this.Name, this.Username, this.Password, User.FindFirst("ID").Value);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Oh snap !!! Something unexpected has occurred ");
            }
            // to do cath all exptions
            return RedirectToPage("LogIn");

        }

    }
}

