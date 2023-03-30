using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUSLOGIC;
using DAL;
using DAL.Exception;
using BUSLOGIC.Exceptions;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
using BUSLOGIC.Classes.UserHandler;

namespace Proiect_din_ala_tank.Pages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public bool RememberUsername { get; set; }
        IUserManager dal = new UserManager(new QueryExecutor(SQLConnect._connectionstring));

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
                   User DatabaseUser = dal.LogIn(this.Username, this.Password);
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, DatabaseUser.Name));
                    claims.Add(new Claim("username",$"{DatabaseUser.Username}"));
                    claims.Add(new Claim("password", $"{DatabaseUser.Password}"));
                    claims.Add(new Claim("id", $"{DatabaseUser.ID}"));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    return RedirectToPage("/Home");
                }
                catch (DatabaseException)
                {
                    ModelState.AddModelError(string.Empty, "The connection to the database was lost");

                    return Page();
                }
                catch (InvalidCredentialsException)
                {
                    ModelState.AddModelError(string.Empty, "That account does not exist. Please check your username and password and try again.");
                    return Page();
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, "Oh snap !!! Something unexpected has occurred " + e);
                    return Page();
                }
            }

            return Page();
        }
    }
}
