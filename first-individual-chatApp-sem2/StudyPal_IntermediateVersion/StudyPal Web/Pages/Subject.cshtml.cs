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
using DAL;

namespace Proiect_din_ala_tank.Pages
{
    [Authorize]
    public class SubjectModel : PageModel
    {
        private ChatRoomManagercs chatRoomManagercs = new ChatRoomManagercs(new QueryExecutor(SQLConnect._connectionstring));
        [BindProperty(SupportsGet = true)]
        public long Id { get; set; }

        public List<ChatRoom> ChatRooms = null;

        string chatRoomName = null;
        public IActionResult OnGet()
        {
            try
            {
                ChatRooms = chatRoomManagercs.GetChatRooms(this.Id);
               
            }
            catch (DatabaseException)
            {
                ModelState.AddModelError(string.Empty, "The connection to the database was lost");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "Oh snap !!! Something unexpected has occurred");
            }

            return Page();


        }

        public IActionResult OnPostCreateRoom(string newChatRoomName)
        {
            chatRoomManagercs.CreateChatRoom(Id, newChatRoomName, Int64.Parse(User.FindFirst("id").Value));
            return RedirectToPage("/Subject", new { Id });
        }


       

    }
}
