using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SEDC.ESchool.DataAccess.Core.Models
{
    public class Student : User
    {
        public bool Present { get; set; }
        public Parent Parent { get; set; }
    }
}
