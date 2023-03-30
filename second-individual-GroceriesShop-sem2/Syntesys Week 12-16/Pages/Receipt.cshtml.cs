using DAL.Repository;
using Logic.Account.Model;
using Logic.Account.Service;
using Logic.Order.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Syntesys_Week_12_16.Pages
{
    [Authorize]
    public class ReceiptModel : PageModel
    {
        private IOrderService orderService = new OrderService(new OrderRepository());
        private IBonusCardService bonusCardService = new BonusCardService(new BonusCardRepository());
        [BindProperty(SupportsGet = true)]
        public int Orderid { get; set; }
        [BindProperty(SupportsGet = true)]
        public Logic.Order.Model.OrderModel OrderModel { get; set; }
        [BindProperty(SupportsGet = true)]
        public BonusCardModel BonusCard { get; set; }
        public void OnGet()
        {
            try
            {
                OrderModel = orderService.GetOrderById(Orderid);
                int userId = Convert.ToInt32(User.FindFirst("userId").Value);
                BonusCard = bonusCardService.GetBonusCard(userId);  
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
