using DAL.DTO;
using Logic.Product.Model;
using Logic.Products.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Product
{
    [TestClass]
    public class ProductModelTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            var DTO = new ProductDTO()
            {
                ProductID = 1,
                CategoryID = 10,
                Description = "Product1",
                Name = "Product1Name",
                Price = 2.55,
                Unit = "kg"
            };

            //Act
            var result = new ProductModel(DTO);


            //Assert
            var expectedCategoryModel = new CategoryModel()
            {
                ID = 10
            };
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID );
            Assert.IsNotNull(result.Category);
            Assert.AreEqual(expectedCategoryModel.ID, result.Category.ID);
            Assert.AreEqual("Product1", result.Description);
            Assert.AreEqual("kg", result.Unit);
            Assert.AreEqual(2.55, result.Price);
            

        }

    }
}
