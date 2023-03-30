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
    public class DeleteAccountModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }
        UserManager dal = new UserManager(new QueryExecutor(SQLConnect._connectionstring));
        public void OnPost()
        {
            dal.DeleteUser(Username,Password);
        }
    }
}
