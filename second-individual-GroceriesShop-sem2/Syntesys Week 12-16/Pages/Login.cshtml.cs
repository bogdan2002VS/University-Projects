using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DAL;
using Logic;
using Logic.Model;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Logic.Account.Service;
using Logic.Order.Model;
using Newtonsoft.Json;
using DAL.Repository;

namespace Syntesys_Week_12_16.Pages
{
    public class LoginModel : PageModel
    {
        IUserService userService = new UserService(new UserRepository());

        [BindProperty]
        public UserModel User { get; set; }

        public IActionResult OnPost()
        {
            try
            {
                User = userService.Login(User);
                if (User != null)
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, User.Name));
                    claims.Add(new Claim("userId", $"{User.ID}"));
                    claims.Add(new Claim("username", $"{User.Username}"));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    return RedirectToPage("/Index");
                }
                else
                {
                    ViewData["invalid_credentials"] = "Username and/or password incorrect.";
                    return Page();
                }
            }
            catch (Exception ex)
            {
                ViewData["Error"] = "Sorry! Something unexpected occurred an couldn't log you in!";
                return Page();
            };

        }
    }
}
