using SEDC.ESchool.DataAccess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Models
{
    public class Subject : BaseEntity
    {
        public SubjectName Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Test> Tests { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Class> Classes { get; set; }
        public Grade Grade { get; set; }
    }
}
