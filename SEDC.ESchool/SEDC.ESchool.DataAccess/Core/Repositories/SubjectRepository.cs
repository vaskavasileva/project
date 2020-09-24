using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class SubjectRepository : IRepository<Subject>
    {
        private IStaticDb _db;
        public SubjectRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(Subject entity)
        {
            _db.Subjects.Add(entity);
        }

        public void Delete(int id)
        {
            var subject = _db.Subjects.SingleOrDefault(x => x.Id == id);
            if (subject != null)
            {
                _db.Subjects.Remove(subject);
            }

        }

        public List<Subject> GetAll()
        {
            return _db.Subjects;
        }

        public Subject GetById(int id)
        {
            return _db.Subjects.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Subject entity)
        {
            var subject = _db.Subjects.SingleOrDefault(x => x.Id == entity.Id);
            if (subject != null)
            {
                _db.Subjects.Remove(subject);
                _db.Subjects.Add(entity);
            }
        }
    }
}
