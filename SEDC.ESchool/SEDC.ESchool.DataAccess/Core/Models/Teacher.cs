using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Models
{
    public class Teacher : User
    {
        public List<Subject> Subjects { get; set; }
    }
}
