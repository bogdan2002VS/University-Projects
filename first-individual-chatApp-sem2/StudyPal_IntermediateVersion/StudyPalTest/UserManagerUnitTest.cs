using DAL;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using BUSLOGIC.Classes.UserHandler;
using System.Collections.Generic;
using DAL.DTO;
namespace StudyPalTest
{
    [TestClass]
    public class UserManagerUnitTest
    {

        [TestMethod]
        public void TestLogin()
        {
            // given
            var fakeData = createFakeData();

            var mock = new Mock<QueryExecutor<object>>();
            mock.Setup(queryExecutorMediator => 
            queryExecutorMediator.Execute(It.IsAny<string>(), It.IsAny<Func<SqlDataReader, object>>())).Returns(fakeData);

            //when
            var testee = new UserManager(mock.Object);
            var myUsername = "myUsername";
            var actualResult = testee.LogIn(myUsername, "myPassword");

            //then
            var wantedResult = new User(fakeData[0]);
            
            Assert.AreEqual(wantedResult, actualResult);
            mock.Verify(queryExecutorMediator => queryExecutorMediator.Execute($"SELECT * FROM Users WHERE Username='{myUsername}'", testee.ProcessResultForUser), Times.Once());


        }


        private static List<UserDTO> createFakeData()
        {
            List<UserDTO> usersDTO = new List<UserDTO>();
            var user1 = new UserDTO();
            user1.Name = "myName";
            user1.Username = "myUsername";
            user1.ID = 1;
            user1.Salt = "mySalt";
            user1.Password = HashingSalting.GenerateSHA256Hash("myPassword", "mySalt");

            var user2 = new UserDTO();
            user2.Name = "myName2";
            user2.Username = "myUsername";
            user2.ID = 2;
            user2.Salt = "mySalt";
            user2.Password = "myPassword2";

            usersDTO.Add(user1);
            usersDTO.Add(user2);
            return usersDTO;
        }
    }
}
