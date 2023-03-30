using BUSLOGIC.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUSLOGIC.Interfaces
{
    internal interface ISubjectManager
    {
        public List<Subject> GetSubjects();

        public Subject GetSubjectsByName(string name);
    }
}
