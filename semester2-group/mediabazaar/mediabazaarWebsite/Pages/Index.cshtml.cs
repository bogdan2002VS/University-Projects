using Logic;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Logic.interfaces;
using Logic.ClassManagers;
using DataL;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Logic.EmployeeTypes;
using Logic.Validation;

namespace mediabazaarWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogIn logIn;
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Credentials Credentials { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            logIn = new LoginLogic(new LogInData(), new EmployeeManager(new EmployeeRepository(), new CredentialsManager(new CredentialsRepository()), new EmployeeValidation()), new CredentialsManager(new CredentialsRepository()));
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    Employee employee = logIn.LogIn(Credentials.Username, Credentials.Password);

                    if (employee != null)
                    {
                        List<Claim> claims = new List<Claim>();

                        claims.Add(new Claim("Employee", JsonConvert.SerializeObject(employee)));

                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                        return RedirectToPage("/schedule");
                    }
                    else
                    {
                        ErrorMessage = "Username or Password are wrong";
                    }
                }

                return Page();
            }
            catch (Exception ex)
            {
                ErrorMessage= ex.Message;
            }

            return Page();
        }
    }
}