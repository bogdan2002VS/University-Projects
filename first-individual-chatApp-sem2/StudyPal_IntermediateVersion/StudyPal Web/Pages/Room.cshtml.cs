using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using BUSLOGIC.Classes;
using BUSLOGIC.Exceptions;
using DAL.Exception;
using System.ComponentModel;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
using BUSLOGIC.Classes.UserHandler;
using System.Text.RegularExpressions;
using DAL;

namespace Proiect_din_ala_tank.Pages
{
    [Authorize]
    public class RoomModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public long ID { get; set; }
        ChatRoomManagercs chatRoomManagercs = new ChatRoomManagercs(new QueryExecutor(SQLConnect._connectionstring));
        [BindProperty]
        public List<Message> messages { get; set; }

        public IActionResult OnGet()
        {
            messages = new List<Message>();
            return Page();

        }
        public async void OnPostSendMessage(string message)
        {
            chatRoomManagercs.SendMessage(ID, message, User.Identity.Name);

        }

        public PartialViewResult OnGetMessages()
        {
            messages = chatRoomManagercs.GetMessages(ID);
            return Partial("_MessagesPartial", messages);
        }
    }
}
