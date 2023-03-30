using DataL;
using Logic;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Logic.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace mediabazaarWebsite.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        private string previousColor;

        public Employee Employee { get; set; }

        public List<string> BackGrounds { get; set; } = new List<string>();

        public IEmployee employeeManager { get; set; }

        public Shift[] Shifts { get; set; }

        public ScheduleModel()
        {
            employeeManager = new EmployeeManager(new EmployeeRepository(), new CredentialsManager(new CredentialsRepository()), new EmployeeValidation());

            BackGrounds.Add("#390099");
            BackGrounds.Add("#8ecae6");
            BackGrounds.Add("#219ebc");
            BackGrounds.Add("#023047");
            BackGrounds.Add("#ffb703");
            BackGrounds.Add("#fb8500");
        }

        public void OnGet()
        {
            if (HttpContext.User.FindFirst("Employee").Value != null)
            {
                Employee = JsonConvert.DeserializeObject<Employee>(HttpContext.User.FindFirst("Employee").Value);
            }

            Shifts = employeeManager.GetEmployeeShifts(Employee.Id).Value;
        }

        public string CalculateTop(Shift a)
        {
            if (a.Start.Hour == 8)
            {
                return "40px";
            }
            else if (a.Start.Hour == 9)
            {
                return "113px";
            }
            else if (a.Start.Hour == 10)
            {
                return "196px";
            }
            else if (a.Start.Hour == 11)
            {
                return "279px";
            }
            else if (a.Start.Hour == 12)
            {
                return "362px";
            }
            else if (a.Start.Hour == 13)
            {
                return "445px";
            }
            else if (a.Start.Hour == 14)
            {
                return "528px";
            }
            else if (a.Start.Hour == 15)
            {
                return "610px";
            }
            else if (a.Start.Hour == 16)
            {
                return "692px";
            }
            else if (a.Start.Hour == 17)
            {
                return "280px";
            }
            return string.Empty;
        }

        public string CalculateHeight(Shift a)
        {
            TimeSpan timeSpan = a.End - a.Start;

            double height = Convert.ToInt32(timeSpan.Hours) * 5.1;

            return $"{height}rem";
        }

        public string GetBackground()
        {
            Random random = new Random();
            string color = BackGrounds[random.Next(BackGrounds.Count)];

            if (color != previousColor)
            {
                previousColor = color;
                return color;
            }

            return string.Empty;
        }
    }
}
