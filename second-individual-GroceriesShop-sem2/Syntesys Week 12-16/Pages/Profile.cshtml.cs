using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Logic.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.ComponentModel;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
using DAL;
using Logic.Account.Service;
using Logic.Order.Service;
using DAL.Repository;

namespace Syntesys_Week_12_16.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        IUserService userService = new UserService(new UserRepository());

        IOrderService orderService = new OrderService(new OrderRepository());

        [BindProperty]
        public Logic.Model.UserProfileModel UserModel { get; set; }
        [BindProperty]
        public List<Logic.Order.Model.OrderModel> OrderModelList { get; set; }

        public void OnGet()
        {   
            try
            {
                int userId = Convert.ToInt32(User.FindFirst("userId").Value);
                UserModel = userService.ReadUserProfile(userId);
                OrderModelList = orderService.GetOrdersByCustomerID(userId);
            } catch(Exception ex)
            {
                ViewData["Profile_Error"] = "An error occured when retrieving user information. Please try again later!";
                Console.Write(ex);
            }

        }

        public void OnPostUpdate()
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst("userId").Value);
                UserModel.ID = userId;
                userService.UpdateUser(UserModel);
                ViewData["Profile_Update"] = "Profile was updated!";

            }
            catch (Exception ex)
            {
                ViewData["Profile_Error"] = "An error occured when retrieving user information. Please try again later!";
                Console.Write(ex);
            }

        }
    }
}
