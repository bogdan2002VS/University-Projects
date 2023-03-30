using DAL.DTO;
using Logic.Model;

namespace LogicTests.Account
{
    [TestClass]
    public class UserModelTest
    {

        [TestMethod]
        public void TestConstructor()
        {
            //Arrange
            var dto = new UserDTO()
            {
                ID = 1,
                Name = "Bogdan Calinescu",
                Email = "my@email.com",
                Password = "pass",
                Role = "Customer",
                Username = "Bogdan"

            };

            //Act
            var result = new UserModel(dto);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
            Assert.AreEqual("Bogdan Calinescu", result.Name);
            Assert.AreEqual("my@email.com", result.Email);
            Assert.AreEqual("Customer", result.Role);
            Assert.AreEqual("Bogdan", result.Username);
            Assert.AreEqual("pass", result.Password);


        }
    }
}
