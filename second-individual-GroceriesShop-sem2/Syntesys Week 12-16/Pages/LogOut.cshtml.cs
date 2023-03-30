using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Syntesys_Week_12_16.Pages
{
    [Authorize]
    public class LogOutModel : PageModel
    {
        public IActionResult OnGet()
        {
            HttpContext.SignOutAsync();
            return Redirect("/Index");
        }

    }
}
