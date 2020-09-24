using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class TeacherRepository : IRepository<Teacher>
    {
        private IStaticDb _db;
        public TeacherRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(Teacher entity)
        {
            _db.Teachers.Add(entity);
        }

        public void Delete(int id)
        {
            var teacher = _db.Teachers.SingleOrDefault(x => x.Id == id);
            if (teacher != null)
            {
                _db.Teachers.Remove(teacher);
            }

        }

        public List<Teacher> GetAll()
        {
            return _db.Teachers;
        }

        public Teacher GetById(int id)
        {
            return _db.Teachers.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Teacher entity)
        {
            var teacher = _db.Teachers.SingleOrDefault(x => x.Id == entity.Id);
            if (teacher != null)
            {
                _db.Teachers.Remove(teacher);
                _db.Teachers.Add(entity);
            }
        }
    }
}
