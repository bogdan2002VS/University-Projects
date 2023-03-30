using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.interfaces
{
    public interface IProduct
    {
        Product[] GetProducts();

        bool AddProduct(Product p);

        bool RemoveProduct(int id);

        bool UpdateProduct(Product p);
        public Product GetProductByBarcode(string barcode);
        public bool SellProduct(int id, int sellingAmount, int sellerID);

        List<Product> SearchProduct(string[] textSearch);

    }
}
