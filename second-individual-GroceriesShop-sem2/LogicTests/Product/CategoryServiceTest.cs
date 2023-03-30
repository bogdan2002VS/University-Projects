using Logic.Product.Model;
using Logic.Product.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Product
{
    [TestClass]
    public class CategoryServiceTest
    {

        [TestMethod]
        public void TestHappyFlowGetAllCategories()
        {
            //Arrange
            var mock = new CategoryRepositoryMock();
            var toTest = new CategoryService(mock);

            //Act
            var realResult = toTest.GetAllCategories();

            //Assert
            var mockDTOs = mock.GetAllCategories();
            var expectedRootCateg1 = new CategoryModel(mockDTOs[0]);

            expectedRootCateg1.subCategories.Add(new CategoryModel(mockDTOs[2]));

            var expectedRootCateg2 = new CategoryModel(mockDTOs[1]);

            var expectedResult = new List<CategoryModel>()
            {
                expectedRootCateg1,
                expectedRootCateg2
            };

            Assert.IsNotNull(realResult);
            Assert.IsTrue(realResult.Count == 2);
            CollectionAssert.AreEqual(expectedResult, realResult);
            CollectionAssert.AreEqual(expectedResult[0].subCategories, realResult[0].subCategories);
            CollectionAssert.AreEqual(expectedResult[1].subCategories, realResult[1].subCategories);
        }

        [TestMethod]
        public void TestExceptionGetAllCategories()
        {
            //Arrange
            var toTest = new CategoryService(null);
            //Act & Assert
            var expectedErrorMessage = "Error getting categories";
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetAllCategories());

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestHapyFlowGetRootCategories()
        {
            //Arrange
            var mock = new CategoryRepositoryMock();
            var toTest = new CategoryService(mock);

            //Act
            var realResult = toTest.GetRootCategories();

            //Assert
            var mockDTOs = mock.GetRootCategories();
            var expectedRootCateg1 = new CategoryModel(mockDTOs[0]);
            var expectedRootCateg2 = new CategoryModel(mockDTOs[1]);

            var expectedResult = new List<CategoryModel>()
            {
                expectedRootCateg1,
                expectedRootCateg2
            };

            Assert.IsNotNull(realResult);
            Assert.IsTrue(realResult.Count == 2);
            CollectionAssert.AreEqual(expectedResult, realResult);

        }

        [TestMethod]
        public void TestExceptionGetRootCategories()
        {
            //Arrange
            var toTest = new CategoryService(null);
            //Act & Assert
            var expectedErrorMessage = "Error getting root categories";
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetRootCategories());

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestHappyFlowGetSubCategoriesByParentId()
        {
            //Arrange
            var mock = new CategoryRepositoryMock();
            var toTest = new CategoryService(mock);

            //Act
            var realResult = toTest.GetSubCategoriesByParentId(1);

            //Assert
            var mockDTOs = mock.GetParentSubCategories(1);
            var expectedCateg1 = new CategoryModel(mockDTOs[0]);
            var expectedCateg2 = new CategoryModel(mockDTOs[1]);

            var expectedResult = new List<CategoryModel>()
            {
                expectedCateg1,
                expectedCateg2
            };

            Assert.IsNotNull(realResult);
            Assert.IsTrue(realResult.Count == 2);
            CollectionAssert.AreEqual(expectedResult, realResult);
        }

        [TestMethod]
        public void TestExceptionGetGetSubCategoriesByParentId()
        {
            //Arrange
            var toTest = new CategoryService(null);
            //Act & Assert
            var expectedErrorMessage = "Error getting categories by parent Id";
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetSubCategoriesByParentId(1));

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

    }
}
