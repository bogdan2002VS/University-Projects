using Logic.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Products.Model;
using DAL;
using DAL.Repository;
using DAL.DTO;

namespace Logic.Product.Service
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void AddProductToCatalog(ProductModel productModel)
        {
            try
            {
                ProductDTO productDTO = new ProductDTO()
                {
                    Name = productModel.Name,
                    Description = productModel.Description,
                    Price = productModel.Price,
                    CategoryID = productModel.Category.ID,
                    Image = productModel.Image,
                    Unit = productModel.Unit
                };
                productRepository.AddProductToCatalog(productDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong when adding product in database", ex);
            }

        }

        public List<ProductModel> GetAllProducts()
        {
            try
            {
                List<ProductModel> productModels = new List<ProductModel>();
                foreach (var productDTO in productRepository.GetAllProducts())
                {
                    productModels.Add(new ProductModel(productDTO));
                }
                return productModels;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong when retrieving products", ex);

            }
        }

        public List<ProductModel> GetProductsBySubcategoryID(int subcategoryId)
        {
            try
            {
                List<ProductModel> productModels = new List<ProductModel>();

                foreach (var productDTO in productRepository.GetProductsBySubcategoryID(subcategoryId))
                {
                    productModels.Add(new ProductModel(productDTO));
                }
                return productModels;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong when retrieving products by subcategory", ex);

            }
        }

        public ProductModel GetProductById(int productId)
        {
            try
            {
                return new ProductModel(productRepository.GetProductById(productId));
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong when retrieving product by Id", ex);

            }
        }

        public void UpdateProduct(ProductModel productModel)
        {
            try
            {
                var productDTO = new ProductDTO()
                {
                    ProductID = productModel.ID,
                    Name = productModel.Name,
                    Description = productModel.Description,
                    CategoryID = productModel.Category.ID,
                    Image = productModel.Image,
                    Price = productModel.Price,
                    Unit = productModel.Unit
                };
                productRepository.UpdateProduct(productDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong when updating product", ex);

            }
        }
        public void DeleteProduct(int id)
        {
            try
            {
                productRepository.DeleteProduct(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not delete product", ex);

            }
        }

    }
}
