using SEDC.ESchool.DataAccess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Models
{
    public class SchoolGroup : BaseEntity
    {
        public GroupLevel Level { get; set; }
        public List<Student> Students { get; set; }
        public Teacher ClassTeacher { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
