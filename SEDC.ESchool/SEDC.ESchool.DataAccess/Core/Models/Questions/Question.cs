using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Models.Questions
{
    public abstract class Question : BaseEntity
    {
        public string QuestionText { get; set; }
    }
}
