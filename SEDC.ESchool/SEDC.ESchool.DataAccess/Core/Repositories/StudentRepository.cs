using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private IStaticDb _db;
        public StudentRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(Student entity)
        {
            _db.Students.Add(entity);
        }

        public void Delete(int id)
        {
            var student = _db.Students.SingleOrDefault(x => x.Id == id);
            if (student != null)
            {
                _db.Students.Remove(student);
            }

        }

        public List<Student> GetAll()
        {
            return _db.Students;
        }

        public Student GetById(int id)
        {
            return _db.Students.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Student entity)
        {
            var student = _db.Students.SingleOrDefault(x => x.Id == entity.Id);
            if (student != null)
            {
                _db.Students.Remove(student);
                _db.Students.Add(entity);
            }
        }
    }
}
