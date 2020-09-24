using SEDC.ESchool.DataAccess.Core.Enums;
using SEDC.ESchool.DataAccess.Core.Models.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Models
{
    public class Test : BaseEntity
    {
        public Test()
        {
            TestGrade = this.GetGrade();
        }
        //Add grade from points
        public List<Question> Questions { get; set; }
        public int Points { get; set; }
        public Grade TestGrade { get; set; }

        public Grade GetGrade()
        {
            if (Points <= 20)
                return Grade.F;
            else if (Points > 20 && Points <= 40)
                return Grade.D;
            else if (Points > 40 && Points <= 60)
                return Grade.C;
            else if (Points > 60 && Points <= 80)
                return Grade.B;
            else
                return Grade.A;
        }
    }
}
