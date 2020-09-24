using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using SEDC.ESchool.DataAccess.Core.Models.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core
{
    public class StaticDb : IStaticDb
    {
        public List<Student> Students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Teacher> Teachers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Subject> Subjects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Parent> Parents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<SchoolGroup> SchoolGroups { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Test> Tests { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Class> Questions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Assignment> Assignments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<AdministrationUser> AdministrationUsers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Question> Questions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
