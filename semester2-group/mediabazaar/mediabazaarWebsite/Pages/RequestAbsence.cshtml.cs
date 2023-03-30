using DataL;
using Logic;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace mediabazaarWebsite.Pages
{
    [Authorize]
    public class RequestAbsenceModel : PageModel
    {
        [BindProperty]
        public string Reason { get; set; }
        [BindProperty]
        public string Description { get; set; }
        [BindProperty]
        public DateTime absenceDate { get; set; }

        public string ErrorMessage { get; set; }

        private readonly IAbsenceManager absenceManager;

        public RequestAbsenceModel()
        {
            absenceManager = new AbsenceManager(new AbsenceRepository());
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostRequestAbsence()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employee employee = JsonConvert.DeserializeObject<Employee>(HttpContext.User.FindFirst("Employee").Value);

                    Absence absence = new Absence
                    {
                        AbsenceReason = Reason,
                        AbsenceDescription = Description,
                        Employee = employee,
                        TicketStatus = 0,
                        Date= absenceDate
                    };

                    bool result = absenceManager.CreateAbsence(absence);

                    if (!result)
                    {
                        return Page();
                    }

                    return RedirectToPage("/schedule");
                }
                else
                {
                    ErrorMessage = "Fill everything";
                }
            }
            catch (Exception)
            {
            }
            return Page();
        }
    }
}
