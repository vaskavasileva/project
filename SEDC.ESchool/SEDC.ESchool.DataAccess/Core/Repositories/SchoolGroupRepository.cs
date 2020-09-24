using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class SchoolGroupRepository : IRepository<SchoolGroup>
    {
        private IStaticDb _db;
        public SchoolGroupRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(SchoolGroup entity)
        {
            _db.SchoolGroups.Add(entity);
        }

        public void Delete(int id)
        {
            var schoolGroup = _db.SchoolGroups.SingleOrDefault(x => x.Id == id);
            if (schoolGroup != null)
            {
                _db.SchoolGroups.Remove(schoolGroup);
            }

        }

        public List<SchoolGroup> GetAll()
        {
            return _db.SchoolGroups;
        }

        public SchoolGroup GetById(int id)
        {
            return _db.SchoolGroups.SingleOrDefault(x => x.Id == id);
        }

        public void Update(SchoolGroup entity)
        {
            var schoolGroup = _db.SchoolGroups.SingleOrDefault(x => x.Id == entity.Id);
            if (schoolGroup != null)
            {
                _db.SchoolGroups.Remove(schoolGroup);
                _db.SchoolGroups.Add(entity);
            }
        }
    }
}
