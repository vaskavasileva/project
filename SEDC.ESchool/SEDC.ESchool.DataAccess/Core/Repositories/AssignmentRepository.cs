using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class AssignmentRepository : IRepository<Assignment>
    {
        private IStaticDb _db;
        public AssignmentRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(Assignment entity)
        {
            _db.Assignments.Add(entity);
        }

        public void Delete(int id)
        {
            var assignment = _db.Assignments.SingleOrDefault(x => x.Id == id);
            if (assignment != null)
            {
                _db.Assignments.Remove(assignment);
            }
            
        }

        public List<Assignment> GetAll()
        {
            return _db.Assignments;
        }

        public Assignment GetById(int id)
        {
            return _db.Assignments.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Assignment entity)
        {
            var assignment = _db.Assignments.SingleOrDefault(x => x.Id == entity.Id);
            if (assignment != null)
            {
                _db.Assignments.Remove(assignment);
                _db.Assignments.Add(entity);
            }
        }
    }
}
