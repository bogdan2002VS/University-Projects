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
    public class SubjectManagerUnitTest
    {
        [TestMethod]
        public void TestGetChatRoomsForAsubject()
        {
            // given
            var fakeData = createFakeSubjects();

            var mock = new Mock<QueryExecutor<object>>();
            mock.Setup(queryExecutorMediator =>
            queryExecutorMediator.Execute(It.IsAny<string>(), It.IsAny<Func<SqlDataReader, object>>())).Returns(fakeData);

            //when
            var testee = new SubjectManager(mock.Object);
            var actualResult = testee.GetSubjects();

            //then
            var wantedResult = new List<Subject>() { new Subject(fakeData[0]), new Subject(fakeData[1]) };
            CollectionAssert.AreEqual(wantedResult, actualResult);
            mock.Verify(queryExecutorMediator => queryExecutorMediator.Execute($"SELECT * FROM Subjects", testee.ProcessResult), Times.Once());

        }

        private static List<SubjectDTO> createFakeSubjects()
        {
            return
                new List<SubjectDTO>(){
                    new SubjectDTO()
                    {
                        ID =1,
                        Name="MySubject",
                        Description= "dada",

                    },
                    new SubjectDTO()
                    {
                        ID = 2,
                        Name = "MySubject2",
                        Description = "tada",
                    }
                };
        }
    }
}
