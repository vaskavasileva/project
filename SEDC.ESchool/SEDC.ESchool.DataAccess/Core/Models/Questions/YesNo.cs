using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Models.Questions
{
    public class YesNo : Question
    {
        public string[] Answers { get; set; } = new string[2];
        public string RightAnswer { get; set; }
    }
}
