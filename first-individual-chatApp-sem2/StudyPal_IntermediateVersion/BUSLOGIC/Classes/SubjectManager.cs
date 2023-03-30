using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BUSLOGIC;
using DAL;
using DAL.DTO;
using BUSLOGIC.Exceptions;
using System.Linq;
using BUSLOGIC.Interfaces;

namespace BUSLOGIC.Classes
{
    public class SubjectManager : ISubjectManager, IHasAdminRights
    {
        private QueryExecutor queryExecutorMediator;
        public SubjectManager(QueryExecutor queryExecutorMediator)
        {
            this.queryExecutorMediator = queryExecutorMediator ?? throw new ArgumentNullException(nameof(queryExecutorMediator));
        }

        public int multiplyByTwo(int number) 
        {
            return 2 * number;
        }

        public List<Subject> GetSubjects ()
        {
            List<SubjectDTO> subjectDTOs = (List<SubjectDTO>)queryExecutorMediator.Execute(
                $"SELECT * FROM Subjects",
               ProcessResult);

            List<Subject> subjects = new List<Subject>();

            foreach (var subjectDTO in subjectDTOs)
            {
                subjects.Add(new Subject(subjectDTO));
            }

            return subjects;

        }

        public Subject GetSubjectsByName(string name)
        {
            SubjectDTO subjectDTO = (SubjectDTO)queryExecutorMediator.Execute(
                $"SELECT * FROM Subjects where Name = '{name}'",
               ProcessResultByName);

            return new Subject(subjectDTO);

        }

        public List<SubjectDTO> ProcessResult(SqlDataReader reader)
        {
            List<SubjectDTO> subjectDTOs = new List<SubjectDTO>();
            while(reader.Read())
            {
                SubjectDTO dto = new SubjectDTO();
                dto.ID = Convert.ToInt64(reader["ID"]);
                dto.Name = reader["Name"].ToString();
                dto.Description = reader["Description"].ToString();

                subjectDTOs.Add(dto);
            }

            return subjectDTOs;
        }
        private SubjectDTO ProcessResultByName(SqlDataReader reader)
        {
            SubjectDTO subjectDTO = new SubjectDTO();
            if (reader.Read())
            {
                subjectDTO.ID = Convert.ToInt64(reader["ID"]);
                subjectDTO.Name = reader["Name"].ToString();
                subjectDTO.Description = reader["Description"].ToString();
            }

            return subjectDTO;
        }

        public int CreateSubject( string name, string description)
        {

            return (int)queryExecutorMediator.Execute(
                 $"INSERT INTO Subjects (Name,Description)  Values('{name}','{description}')",
                CreateSubjectProcessResult);

        }

        private object CreateSubjectProcessResult(SqlDataReader reader)
        {
            return 1;
        }

    }
}

