using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class ParentRepository : IRepository<Parent>
    {
        private IStaticDb _db;
        public ParentRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(Parent entity)
        {
            _db.Parents.Add(entity);
        }

        public void Delete(int id)
        {
            var parent = _db.Parents.SingleOrDefault(x => x.Id == id);
            if (parent != null)
            {
                _db.Parents.Remove(parent);
            }

        }

        public List<Parent> GetAll()
        {
            return _db.Parents;
        }

        public Parent GetById(int id)
        {
            return _db.Parents.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Parent entity)
        {
            var parent = _db.Parents.SingleOrDefault(x => x.Id == entity.Id);
            if (parent != null)
            {
                _db.Parents.Remove(parent);
                _db.Parents.Add(entity);
            }
        }
    }
}
