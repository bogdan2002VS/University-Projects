using DAL;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using BUSLOGIC.Classes;
using System.Collections.Generic;
using DAL.DTO;
namespace StudyPalTest
{
    [TestClass]
    public class ChatRoomManagerUnitTest
    {
        // inspiration : https://docs.educationsmediagroup.com/unit-testing-csharp/moq/quick-glance-at-moq
        // https://stackoverflow.com/questions/19562505/assert-to-compare-two-lists-of-objects-c-sharp

        [TestMethod]
        public void TestGetChatRoomsForAsubject()
        {
            // given
            var fakeData = createFakeChatRooms();

            var mock = new Mock<QueryExecutor>();
            mock.Setup(queryExecutorMediator =>
            queryExecutorMediator.Execute(It.IsAny<string>(), It.IsAny<Func<SqlDataReader, object>>())).Returns(fakeData);

            //when
            var testee = new ChatRoomManagercs(mock.Object);
            var mySubjectId = 123;
            var actualResult = testee.GetChatRooms(mySubjectId);

            //then
            var wantedResult = new List<ChatRoom>() { new ChatRoom(fakeData[0]), new ChatRoom(fakeData[1]) };
            CollectionAssert.AreEqual(wantedResult, actualResult);
            mock.Verify(queryExecutorMediator => queryExecutorMediator.Execute($"SELECT * FROM ChatRooms where SubjectID = {mySubjectId}", testee.ProcessResult), Times.Once());

        }
        [TestMethod]
        public void TestmultiplyByTwo()
        {
            SubjectManager subjectManager = null;

            int result = subjectManager.multiplyByTwo(2);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestGetChatRoomsForAsubjectWithNoMOck()
        {
            // given
            var fakeData = createFakeChatRooms();
            QueryExecutor queryExecutor = new QueryExecutor();
            
            //when
            var testee = new ChatRoomManagercs(queryExecutor);
            var mySubjectId = 123;
            var actualResult = testee.GetChatRooms(mySubjectId);

            //then
            var wantedResult = new List<ChatRoom>() { new ChatRoom(fakeData[0]), new ChatRoom(fakeData[1]) };
            CollectionAssert.AreEqual(wantedResult, actualResult);
            //mock.Verify(queryExecutorMediator => queryExecutorMediator.Execute($"SELECT * FROM ChatRooms where SubjectID = {mySubjectId}", testee.ProcessResult), Times.Once());

        }

        private static List<ChatRoomDTO> createFakeChatRooms()
        {
            return
                new List<ChatRoomDTO>(){
                    new ChatRoomDTO()
                    {
                        ID =1,
                        AdminID= 12,
                        Subject= 123,
                        Name="MyChatRoom"
                    },
                    new ChatRoomDTO()
                    {
                        ID =2,
                        AdminID= 12,
                        Subject= 123,
                        Name="MyChatRoom2"
                    }
                };
        }

    }
}
