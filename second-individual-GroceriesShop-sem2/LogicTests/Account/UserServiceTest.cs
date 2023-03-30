using Logic.Account.Service;
using Logic.Account.Util;
using Logic.Model;
using Logic.Order.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTests.Account
{
    [TestClass]
    public class UserServiceTest
    {
        [TestMethod]
        public void TestHappyFlowLogin()
        {
            //Arrange
            var mock = new UserRepositoryMock();
            var toTest = new UserService(mock);

            //Act
            UserModel result = toTest.Login(new UserModel()
            {
                Username = "Bogdan",
                Password = "password"
            }
            );

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Name, "Bogdan Calinescu");
            Assert.AreEqual(result.ID, 1);
            Assert.AreEqual(result.Role, "Customer");
            Assert.AreEqual(result.Username, "Bogdan");

        }

        [TestMethod]
        public void TestLoginAlternativeWithInvalidCredentials()
        {
            //Arrange
            var mock = new UserRepositoryMock();
            var toTest = new UserService(mock);

            //Act
            UserModel result = toTest.Login(new UserModel()
            {
                Username = "Bogdan",
                Password = "wrondPassword"
            }
            );

            // login should return null when it could not match username & password from the database (+salt)
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestHappyFlowReadUserProfile()
        {
            var mock = new UserRepositoryMock();
            var toTest = new UserService(mock);

            //Act
            UserProfileModel result = toTest.ReadUserProfile(1);
            
            Assert.IsNotNull(result);
            Assert.AreEqual("Bogdan Calinescu", result.Name);
            Assert.AreEqual(1, result.ID);
            Assert.AreEqual("Bogdan", result.Username);
            Assert.AreEqual("my@email.com", result.Email);
        }

        [TestMethod]
        public void TestExceptionLogin()
        {
            //Arrange
            var toTest = new UserService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.Login(null));
            var expectedErrorMessage = "Could not log in";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestExceptionReadUserProfile()
        {
            //Arrange
            var toTest = new UserService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.ReadUserProfile(1));
            var expectedErrorMessage = "Could not read userProfile";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestHappyFlowRegisterCustomer()
        {
            var repo = new UserRepositoryMock();
            var toTest = new UserService(repo);
            var input = new UserModel()
            {
                Email = "my@gmail.com",
                Name = "Bogdan",
                Password = "myPassword",
                Username = "bogdan"
            };
            //Act 
            toTest.RegisterCustomer(input);

            //Assert
            Assert.AreEqual("Bogdan", repo.UserToCreate.Name);
            Assert.AreEqual("bogdan", repo.UserToCreate.Username);
            Assert.AreEqual("my@gmail.com", repo.UserToCreate.Email);
            Assert.AreEqual("Customer", repo.UserToCreate.Role);
            string hashedCheckPassword = HashingSalting.GenerateSHA256Hash("myPassword", repo.UserToCreate.Salt);
            Assert.AreEqual(hashedCheckPassword, repo.UserToCreate.Password);


        }

        [TestMethod]
        public void TestHappyFlowRegisterEmployee()
        {
            var repo = new UserRepositoryMock();
            var toTest = new UserService(repo);
            var input = new UserModel()
            {
                Email = "my@gmail.com",
                Name = "Bogdan",
                Password = "myPassword",
                Username = "bogdan"
            };
            //Act 
            toTest.RegisterEmployee(input);

            //Assert
            Assert.AreEqual("Bogdan", repo.UserToCreate.Name);
            Assert.AreEqual("bogdan", repo.UserToCreate.Username);
            Assert.AreEqual("my@gmail.com", repo.UserToCreate.Email);
            Assert.AreEqual("Staff", repo.UserToCreate.Role);

            string hashedCheckPassword = HashingSalting.GenerateSHA256Hash("myPassword", repo.UserToCreate.Salt);
            Assert.AreEqual(hashedCheckPassword, repo.UserToCreate.Password);


        }


        [TestMethod]
        public void TestHappyFlowUpdateUser()
        {
            var repo = new UserRepositoryMock();
            var toTest = new UserService(repo);
            var input = new UserProfileModel()
            {
                ID = 1, 
                Email = "my@gmail.com",
                Name = "Bogdan",
                Username = "bogdan"
            };
            //Act 
            toTest.UpdateUser(input);

            //Assert
            Assert.AreEqual("Bogdan", repo.UserToUpdate.Name);
            Assert.AreEqual("bogdan", repo.UserToUpdate.Username);
            Assert.AreEqual("my@gmail.com", repo.UserToUpdate.Email);
            Assert.AreEqual("Bogdan", repo.UserToUpdate.Name);

        }

        [TestMethod]
        public void TestExceptionFlowRegisterCustomer()
        {
            //Arrange
            var toTest = new UserService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.RegisterCustomer(null));
            var expectedErrorMessage = "Could not create customer user";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestExceptionFlowRegisterEmployee()
        {
            //Arrange
            var toTest = new UserService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.RegisterEmployee(null));
            var expectedErrorMessage = "Could not create employee user";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }

        [TestMethod]
        public void TestExceptionFlowUpdateUser()
        {
            //Arrange
            var toTest = new UserService(null);

            //Act && Assert
            var ex = Assert.ThrowsException<Exception>(() => toTest.UpdateUser(null));
            var expectedErrorMessage = "Could not update user";

            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }
    }
}
