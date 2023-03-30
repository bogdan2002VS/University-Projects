using DAL.Repository;
using Logic.Account.Model;
using Logic.Account.Service;
using Logic.Order.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Windows.Data.Json;
using Windows.UI.Xaml.Controls;

namespace Syntesys_Week_12_16.Pages
{
    public class ShoppingCartModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public CartModel Cart { get; set; }

        private IBonusCardService bonusCardService = new BonusCardService(new BonusCardRepository());
        public void OnGet()
        {
            try
            {
                if (HttpContext.Session.GetString("cart") != null)
                {
                    this.Cart = JsonConvert.DeserializeObject<CartModel>(HttpContext.Session.GetString("cart"));
                }
                else
                {
                    this.Cart = new CartModel();
                }
                int userId = Convert.ToInt32(User.FindFirst("userId").Value);

                this.Cart.BonusCard = bonusCardService.GetBonusCard(userId);
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(this.Cart));

            }
            catch (Exception ex)
            {
                ViewData["Error"] = "Could retrieve shopping cart";
            }

        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            try
            {
                Cart = JsonConvert.DeserializeObject<CartModel>(HttpContext.Session.GetString("cart"));
                for (var i = 0; i < Cart.Items.Count; i++)
                {
                    Cart.Items[i].Quantity = quantities[i];
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(Cart));
            }
            catch (Exception ex)
            {
                ViewData["Error"] = "Could not update quantity";
            }
            return RedirectToPage("ShoppingCart");
        }

        public IActionResult OnPostDelete(int id)
        {
            try
            {
                Cart = JsonConvert.DeserializeObject<CartModel>(HttpContext.Session.GetString("cart"));

                int index = Exists(Cart.Items, id);
                Cart.Items.RemoveAt(index);
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(Cart));

                return RedirectToPage("ShoppingCart");
            }
            catch (Exception)
            {
                ViewData["Error"] = "Error deleting item";
                return RedirectToPage("ShoppingCart");
            }

        }

        public void OnPostBonus(int selectedBonusPoints)
        {
            try
            {  //save selected bonus points
                Cart = JsonConvert.DeserializeObject<CartModel>(HttpContext.Session.GetString("cart"));
                Cart.BonusCard.BonusPointsToApply = selectedBonusPoints;
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(Cart));
            }
            catch (Exception ex)
            {
                ViewData["Error"] = "Could not apply bonus points";
            }
        }

        private int Exists(List<ItemModel> items, int id)
        {
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].Product.ID == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public IActionResult OnPostCheckout()
        {
            try
            {  //save selected bonus points
                Cart = JsonConvert.DeserializeObject<CartModel>(HttpContext.Session.GetString("cart"));
                int usedBonus = Cart.BonusCard.BonusPointsToApply;
                if (usedBonus > Cart.BonusCard.BonusCardPoints)
                {
                    ViewData["Error"] = "Could not apply bonus points because is bigger then total points available";
                    Cart.BonusCard.BonusPointsToApply = 0;
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(Cart));
                    return Page();

                }

                if (Cart.TotalPrice < 0)
                {
                    ViewData["Error"] = "Could not apply discount because is bigger than the amount to pay! ";
                    Cart.BonusCard.BonusPointsToApply = 0;
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(Cart));
                    return Page();
                };

                if (Cart.Items == null || Cart.Items.Count == 0)
                {
                    ViewData["Error"] = "Your shopping cart is empty, please add some products! ";
                    Cart.BonusCard.BonusPointsToApply = 0;
                    return Page();
                };


            }
            catch (Exception ex)
            {
                ViewData["Error"] = "Could not apply bonus points";
            }
            return RedirectToPage("/Order");
        }


    }
}
