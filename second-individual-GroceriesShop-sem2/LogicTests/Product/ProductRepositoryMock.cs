using DAL.DTO;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Product
{
    public class ProductRepositoryMock : IProductRepository
    {
        public ProductDTO ProductDTOAdd;  
        public ProductDTO ProductDTOUpdate;

        public void AddProductToCatalog(ProductDTO productDTO)
        {
            ProductDTOAdd = productDTO;
        }

        public void DeleteProduct(int id)
        {

        }

        public List<ProductDTO> GetAllProducts()
        {
            return new List<ProductDTO>()
            {
                new ProductDTO()
                {
                    ProductID = 1,
                    CategoryID = 1,
                    Description ="Product1",
                    Name = "Product1Name",
                    Price = 2.55,
                    Unit = "kg"
                },
                new ProductDTO()
                {
                    ProductID = 2,
                    CategoryID = 2,
                    Description ="Product2",
                    Name = "Product2Name",
                    Price = 0.55,
                    Unit = "pack"
                }
            };
        }

        public ProductDTO GetProductById(int id)
        {
            return new ProductDTO()
            {
                ProductID = 1,
                CategoryID = 1,
                Description = "Product1",
                Name = "Product1Name",
                Price = 2.55,
                Unit = "kg"
            };
        }

        public List<ProductDTO> GetProductsBySubcategoryID(int id)
        {
            return new List<ProductDTO>()
            {
                new ProductDTO()
                {
                    ProductID = 1,
                    CategoryID = 1,
                    Description ="Product1",
                    Name = "Product1Name",
                    Price = 2.55,
                    Unit = "kg"
                },
                new ProductDTO()
                {
                    ProductID = 2,
                    CategoryID = 2,
                    Description ="Product2",
                    Name = "Product2Name",
                    Price = 0.55,
                    Unit = "pack"
                }
            };
        }

        public void UpdateProduct(ProductDTO productDTO)
        {
            ProductDTOUpdate = productDTO;
        }
    }
}
