using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Models.Questions
{
    public class MultipleChoice : Question
    {
        public List<string> Choices { get; set; }
        public string RightChoice { get; set; }
    }
}
