using Logic.Account.Model;
using Logic.Account.Service;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Account
{
    [TestClass]
    public class BonusCardsServiceTest
    {
        [TestMethod]
        public void TestHappyFlowGetBonusCard()
        {
            var mock = new BonusCardRepositoryMock();
            var toTest = new BonusCardService(mock);

            //Act
            var result = toTest.GetBonusCard(1);
            var expectedUser = new UserModel()
            {
                ID = 12
            };

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.BonusCardId);
            Assert.AreEqual(100, result.BonusCardPoints);
            Assert.IsNotNull(result.UserModel);
            Assert.AreEqual(expectedUser.ID, result.UserModel.ID);

        }

        [TestMethod]
        public void TestExceptionGetBonusCard()
        {
            var toTest = new BonusCardService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.GetBonusCard(1));
            var expectedErrorMessage = "Could not get bonus card";

            Assert.AreEqual(expectedErrorMessage, ex.Message);

        }

        [TestMethod]
        public void TestCreateUserBonusCard()
        {
            //Arrange
            var repository = new BonusCardRepositoryMock();
            var toTest = new BonusCardService(repository);

            //Act
            toTest.CreateBonusCard(1);

            //assert that the repository was called with the right values by the service
            Assert.IsNotNull(repository.BonusCardDTOAdded);
            Assert.AreEqual(1, repository.BonusCardDTOAdded.UserId);
            Assert.AreEqual(0, repository.BonusCardDTOAdded.TotalBonusPoints);

        }

        [TestMethod]
         public void TestUpdateBonusCard()
        {
            var mock = new BonusCardRepositoryMock();
            var toTest = new BonusCardService(mock);

            toTest.UpdateBonusCard(new BonusCardModel()
            {
                BonusCardPoints = 100,
                BonusPointsToApply = 20,
                UserModel = new UserModel()
                {
                    ID = 12
                }
            });

            //Assert
            Assert.IsNotNull(mock.BonusCardDTOUpdated);
            Assert.AreEqual(120, mock.BonusCardDTOUpdated.TotalBonusPoints);
            Assert.AreEqual(12, mock.BonusCardDTOUpdated.UserId);

        }

        [TestMethod]
        public void TestExceptionUpdateBonusCard()
        {
            var toTest = new BonusCardService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.UpdateBonusCard(null));
            var expectedErrorMessage = " Error when add bonus points to Card";

            Assert.AreEqual(expectedErrorMessage, ex.Message);

        }

        [TestMethod]
        public void TestExceptionCreateBonusCard()
        {
            var toTest = new BonusCardService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.CreateBonusCard(-1));
            var expectedErrorMessage = "Could not create bonus card";


            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

    }
}
