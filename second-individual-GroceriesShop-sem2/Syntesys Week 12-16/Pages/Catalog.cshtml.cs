using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Logic.Products;
using Logic.Products.Model;
using Logic.Product.Service;
using Logic.Order.Model;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using DAL.Repository;

namespace Syntesys_Week_12_16.Pages
{
    public class CatalogModel : PageModel
    {
        ProductService productService = new ProductService(new ProductRepository());

        [BindProperty (SupportsGet = true)]
        public int ID { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<ProductModel> ProductList { get; set; }
        public void OnGet()
        {
            try
            {
                this.ProductList = productService.GetProductsBySubcategoryID(this.ID);

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "Oh snap !!! Something unexpected has occurred");
            }

        }

        public void OnGetAddToCart(int productId)
        {

            var cartModel = JsonConvert.DeserializeObject<CartModel>(HttpContext.Session.GetString("cart"));
            var existingItem = cartModel.Items.FirstOrDefault(item => item.Product.ID == productId);

            if (existingItem == null) {
                existingItem = new ItemModel();
                existingItem.Product = productService.GetProductById(productId);
                existingItem.Quantity = 1;
                cartModel.Items.Add(existingItem);
            }
            else
            {
                existingItem.Quantity = existingItem.Quantity + 1;
            }

            HttpContext.Session.SetString("cart",JsonConvert.SerializeObject(cartModel));
        }
    }
}
