using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DTO;

namespace DAL.Repository
{
    public interface IProductRepository
    {

        public void AddProductToCatalog(ProductDTO productDTO);
        public List<ProductDTO> GetAllProducts();
        public List<ProductDTO> GetProductsBySubcategoryID(int categoryId);
        public ProductDTO GetProductById(int id);

        public void UpdateProduct(ProductDTO productDTO);
        public void DeleteProduct(int productId);


    }
}
