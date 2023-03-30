using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataL.DTO;

namespace DataL.interfaces
{
    public interface IProductRepository
    {
        ProductDTO[] GetProducts();

        bool AddProduct(ProductDTO p);

        bool RemoveProduct(int id);
        bool UpdateProduct(ProductDTO p);
        public ProductDTO GetProductByBarcode(string barcode);
        public bool SellProduct(int id, int sellingAmount, int sellerID);
    }
}
