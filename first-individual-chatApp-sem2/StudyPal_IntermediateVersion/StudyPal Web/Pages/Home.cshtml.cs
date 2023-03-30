using BUSLOGIC.Classes;
using DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proiect_din_ala_tank.Pages
{
    [Authorize]
    public class HomeModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public long ID { get; set; }

        [BindProperty]
        public List<Subject> subjects { get; set; }

        [BindProperty]
        public bool IsDrawerVisible { get; set; } 

        BUSLOGIC.Classes.SubjectManager dal = new BUSLOGIC.Classes.SubjectManager(new QueryExecutor(SQLConnect._connectionstring));

        public IActionResult OnGet()
        {
                this.subjects = dal.GetSubjects();
            return Page();
        }

        public IActionResult OnGetLogout()
        {
            
            return RedirectToPage("Index");
        }
    }
}
