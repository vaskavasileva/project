using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class ClassRepository : IRepository<Class>
    {
        private IStaticDb _db;
        public ClassRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(Class entity)
        {
            _db.Classes.Add(entity);
        }

        public void Delete(int id)
        {
            var currentClass = _db.Classes.SingleOrDefault(x => x.Id == id);
            if (currentClass != null)
            {
                _db.Classes.Remove(currentClass);
            }

        }

        public List<Class> GetAll()
        {
            return _db.Classes;
        }

        public Class GetById(int id)
        {
            return _db.Classes.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Class entity)
        {
            var currentClass = _db.Classes.SingleOrDefault(x => x.Id == entity.Id);
            if (currentClass != null)
            {
                _db.Classes.Remove(currentClass);
                _db.Classes.Add(entity);
            }
        }
    }
}
