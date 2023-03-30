using System;
using System.Collections.Generic;
using System.Text;
using DAL.DTO;

namespace BUSLOGIC.Classes
{
    public class Subject
    {
        private long id;
        private string name;
        private string description;
        
        public Subject(SubjectDTO subjectDTO)
        {
            this.id = subjectDTO.ID;
            this.name = subjectDTO.Name;
            this.description = subjectDTO.Description;
        }
       
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public long Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Subject subject &&
                   id == subject.id &&
                   name == subject.name &&
                   description == subject.description;
        }
    }
}
