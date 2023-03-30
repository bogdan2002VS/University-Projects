using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Products.Model;
using DAL;

namespace Logic.Product.Service
{
    public interface IProductService
    {
        public void AddProductToCatalog(ProductModel productModel);
        public List<ProductModel> GetAllProducts();

        public List<ProductModel> GetProductsBySubcategoryID(int subcategoryId);

        public ProductModel GetProductById(int productId);
        public void UpdateProduct(ProductModel productModel);

        public void DeleteProduct(int productId);
    }
}
