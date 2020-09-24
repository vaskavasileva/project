using SEDC.ESchool.DataAccess.Core.Models;
using SEDC.ESchool.DataAccess.Core.Models.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Interfaces
{
    public interface IStaticDb
    {
        List<Student> Students { get; set; }
        List<Teacher> Teachers { get; set; }
        List<Subject> Subjects { get; set; }
        List<Parent> Parents { get; set; }
        List<SchoolGroup> SchoolGroups { get; set; }
        List<Test> Tests { get; set; }
        List<Class> Classes { get; set; }
        List<Assignment> Assignments { get; set; }
        List<AdministrationUser> AdministrationUsers { get; set; }
        List<Question> Questions { get; set; }
    }
}
