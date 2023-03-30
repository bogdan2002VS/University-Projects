using Logic.Order.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Logic.Order.Service;
using Logic;
using Logic.Account.Service;
using DAL.Repository;

namespace Syntesys_Week_12_16.Pages
{
    [Authorize]
    public class OrderModel : PageModel
    {

        IOrderService orderService = new OrderService(new OrderRepository());
        IBonusCardService bonusCardService = new BonusCardService(new BonusCardRepository());

        [BindProperty(SupportsGet = true)]
        public Logic.Order.Model.OrderModel Order { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {

                int order_Id = 0;
                try
                {

                    Order.ShoppingCart = JsonConvert.DeserializeObject<CartModel>(HttpContext.Session.GetString("cart"));
                    Order.UserModel = new CustomerModel()
                    {
                        ID = (Convert.ToInt32(User.FindFirst("userId").Value))
                    };

                    order_Id = orderService.CreateOrder(Order);

                    int usedBonusPoints = Order.ShoppingCart.BonusCard.BonusPointsToApply;
                    int bonusPointsEarnedFromOrder = Convert.ToInt32(Order.ShoppingCart.TotalPrice);

                    Order.ShoppingCart.BonusCard.BonusPointsToApply = bonusPointsEarnedFromOrder - usedBonusPoints;

                    bonusCardService.UpdateBonusCard(Order.ShoppingCart.BonusCard);

                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(new CartModel()));

                }
                catch (Exception ex)
                {
                    ViewData["Order_Error"] = "Ops! Could not make your order. Please try again later!";
                    Console.Write(ex);
                    return Page();
                }
                return RedirectToPage("/Receipt", new { orderid = order_Id });

            }
            return Page();
        }
    }
}
