using DAL.DTO;
using DAL.Repository;
using Logic.Product.Service;
using Logic.Products.Model;

namespace LogicTests.Product
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void TestHappyFlowGetAllProducts()
        {
            //Arrange
            var repositoryMock = new ProductRepositoryMock();
            var toTest = new ProductService(repositoryMock);

            //Act
            List<ProductModel> result = toTest.GetAllProducts();



            //Assert
            List<ProductDTO> productDTOsMock = repositoryMock.GetAllProducts();
            var expected = new List<ProductModel>
            {
                new ProductModel(productDTOsMock[0]),
                new ProductModel(productDTOsMock[1])
            };
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 2);
            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestGetAllProductsThowException()
        {   //Arrange
            var toTest = new ProductService(null);

            //Act
            //Assert
            var expectedErrorMessage = "Something went wrong when retrieving products";
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetAllProducts());

            Assert.AreEqual(expectedErrorMessage, ex.Message);

        }

        [TestMethod]
        public void TestHappyFlowGetProductsBySubcategoryID()
        {
            var repositoryMock = new ProductRepositoryMock();
            var toTest = new ProductService(repositoryMock);

            //Act
            List<ProductModel> result = toTest.GetProductsBySubcategoryID(1);


            //Assert
            List<ProductDTO> productDTOsMock = repositoryMock.GetProductsBySubcategoryID(1);
            var expected = new List<ProductModel>
            {
                new ProductModel(productDTOsMock[0]), // assigning values from DTO to Model is tested in ProductModel
                new ProductModel(productDTOsMock[1])
            };
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 2);
            CollectionAssert.AreEqual(expected, result); 
        }

        [TestMethod]
        public void TestHappyFlowGetProductById()
        {
            var repositoryMock = new ProductRepositoryMock();
            var toTest = new ProductService(repositoryMock);

            //Act
            ProductModel result = toTest.GetProductById(1);


            //Assert
            List<ProductDTO> productDTOsMock = repositoryMock.GetProductsBySubcategoryID(1);
            var expected = new ProductModel(productDTOsMock[0]); // assigning values from DTO to Model is tested in ProductModel
               
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetProductsBySubcategoryIDThowException()
        {   //Arrange
            var toTest = new ProductService(null);

            //Act
            //Assert
            var expectedErrorMessage = "Something went wrong when retrieving products by subcategory";
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetProductsBySubcategoryID(1));

            Assert.AreEqual(expectedErrorMessage, ex.Message);

        }

        [TestMethod]
        public void TestGetProductByIdThowException()
        {   //Arrange
            var toTest = new ProductService(null);

            //Act
            //Assert
            var expectedErrorMessage = "Something went wrong when retrieving product by Id";
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetProductById(1));

            Assert.AreEqual(expectedErrorMessage, ex.Message);

        }

        [TestMethod]
        public void TestHappyFlowAddProductToCatalog()
        {
            var repositoryMock = new ProductRepositoryMock();
            var toTest = new ProductService(repositoryMock);
            var image = new byte[] { 0x00, 0x21 };
            var product = new ProductModel()
            {
                Category = new Logic.Product.Model.CategoryModel()
                {
                    ID = 1,
                    Name = "Fruits"
                },
                Description = "productDescription",
                Name = "prductName",
                Price = 1.99,
                Unit = "kg",
                Image = image
            };


            //Act
            toTest.AddProductToCatalog(product);


            //Assert

            Assert.IsNotNull(repositoryMock.ProductDTOAdd);
            Assert.AreEqual(image, repositoryMock.ProductDTOAdd.Image);
            Assert.AreEqual("prductName", repositoryMock.ProductDTOAdd.Name);
            Assert.AreEqual("productDescription", repositoryMock.ProductDTOAdd.Description);
            Assert.AreEqual(1, repositoryMock.ProductDTOAdd.CategoryID);
            Assert.AreEqual(1.99, repositoryMock.ProductDTOAdd.Price);
            Assert.AreEqual("kg", repositoryMock.ProductDTOAdd.Unit);
        }

        [TestMethod]
        public void TestAddProductToCatalogThrowException()
        {   //Arrange
            var toTest = new ProductService(new ProductRepositoryMock());

            //Act
            //Assert
            var expectedErrorMessage = "Something went wrong when adding product in database";
            var ex = Assert.ThrowsException<Exception>(() => toTest.AddProductToCatalog(null));

            Assert.AreEqual(expectedErrorMessage, ex.Message);

        }

        [TestMethod]
        public void TestHappyFlowUpdateProduct()
        {
            var repositoryMock = new ProductRepositoryMock();
            var toTest = new ProductService(repositoryMock);
            var image = new byte[] { 0x00, 0x21 };
            var product = new ProductModel()
            {
                Category = new Logic.Product.Model.CategoryModel()
                {
                    ID = 1,
                    Name = "Fruits"
                },
                Description = "productDescription",
                Name = "prductName",
                Price = 1.99,
                Unit = "kg",
                Image = image
            };


            //Act
            toTest.UpdateProduct(product);


            //Assert

            Assert.IsNotNull(repositoryMock.ProductDTOUpdate);
            Assert.AreEqual(image, repositoryMock.ProductDTOUpdate.Image);
            Assert.AreEqual("prductName", repositoryMock.ProductDTOUpdate.Name);
            Assert.AreEqual("productDescription", repositoryMock.ProductDTOUpdate.Description);
            Assert.AreEqual(1, repositoryMock.ProductDTOUpdate.CategoryID);
            Assert.AreEqual(1.99, repositoryMock.ProductDTOUpdate.Price);
            Assert.AreEqual("kg", repositoryMock.ProductDTOUpdate.Unit);
        }

        [TestMethod]
        public void TestUpdateProductThrowException()
        {   //Arrange
            var toTest = new ProductService(new ProductRepositoryMock());

            //Act
            //Assert
            var expectedErrorMessage = "Something went wrong when updating product";
            var ex = Assert.ThrowsException<Exception>(() => toTest.UpdateProduct(null));

            Assert.AreEqual(expectedErrorMessage, ex.Message);

        }
    }
}
