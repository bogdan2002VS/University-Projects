using DataL.DTO;
using DataL.interfaces;
using Logic.interfaces;
using Logic.Pool;

namespace Logic.ClassManagers
{
    public class ProductManager : IProduct
    {
        private readonly IProductRepository productRepository;
        private List<Product> products;
        public ProductManager(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void DeactivateProduct(Product p)
        {
            foreach (Product pr in products)
            {
                if (pr == p)
                {
                    //pr.State = ProductState.UNAVAILABLE;
                }
            }
        }

        public void SortProductsBy()
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(Product p)
        {
            ProductDTO productDTO = ConverterPool.GetConverter<Product, ProductDTO>().Convert(p);

            return productRepository.AddProduct(productDTO);
        }
        

        public bool RemoveProduct(int id)
        {
            return productRepository.RemoveProduct(id);
        }

        public bool UpdateProduct(Product p)
        {
            ProductDTO productDTO = ConverterPool.GetConverter<Product, ProductDTO>().Convert(p);

            return productRepository.UpdateProduct(productDTO);
        }

        public Product[] GetProducts()
        {
            List<ProductDTO> productsDTO = productRepository.GetProducts().ToList();

            Product[] products = ConverterPool.GetConverter<Product, ProductDTO>().Convert(productsDTO);

            return products;
        }

        public Product GetProductByBarcode(string barcode)
        {
            ProductDTO productDTO = productRepository.GetProductByBarcode(barcode);

            Product products = new Product(productDTO);

            return products;
        }

        public bool SellProduct(int id, int sellingAmount, int sellerID)
        {
            return productRepository.SellProduct(id, sellingAmount, sellerID);
        }

        public List<Product> SearchProduct(string[] textSearch)
        {
            List<Product> products = SearchSystem<Product>.Search(textSearch, GetProducts().ToList());

            return products;
        }
    }
}