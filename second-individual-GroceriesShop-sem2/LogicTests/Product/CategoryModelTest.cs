using DAL.DTO;
using Logic.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Product
{
    [TestClass]
    public class CategoryModelTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            //Arrange
            var dto = new CategoryDTO()
            {
                ID = 1,
                Image = "image.url",
                Name = "category",
                ParentID = 11
            };

            //Act
            var result = new CategoryModel(dto);


            //Assert
            Assert.AreEqual(1, result.ID);
            Assert.AreEqual("image.url", result.Image);
            Assert.AreEqual("category", result.Name);
            Assert.IsNotNull(result.subCategories);
        }
    }
}
