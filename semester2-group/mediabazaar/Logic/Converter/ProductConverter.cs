using DataL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class ProductConverter : IConverter<Product, ProductDTO>
    {
        public ProductDTO Convert(Product source_object)
        {
            ProductDTO productDTO = new ProductDTO()
            {
                Id= source_object.Id,
                ProductName = source_object.ProductName,
                Amount = source_object.Amount,
                Price = source_object.Price,
                ProductState = (int)source_object.ProductState,
                Barcode= source_object.Barcode,
                MinStock= source_object.MinStock,
            };

            return productDTO;
        }

        public Product Convert(ProductDTO source_object)
        {
            Product product = new Product()
            {
                Id = source_object.Id,
                ProductName = source_object.ProductName,
                Amount = source_object.Amount,
                Price = source_object.Price,
                ProductState = (ProductState)source_object.ProductState,
                Barcode = source_object.Barcode,
                MinStock = source_object.MinStock,
            };

            return product;
        }

        public ProductDTO[] Convert(List<Product> source_object)
        {
            List<ProductDTO> result = new List<ProductDTO>();
            foreach (Product item in CollectionsMarshal.AsSpan(source_object))
            {
                result.Add(Convert(item));
            }

            return result.ToArray();
        }

        public Product[] Convert(List<ProductDTO> source_object)
        {
            List<Product> result = new List<Product>();
            foreach (ProductDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                result.Add(Convert(item));
            }

            return result.ToArray();
        }
    }
}
