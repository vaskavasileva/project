using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class TestRepository : IRepository<Test>
    {
        private IStaticDb _db;
        public TestRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(Test entity)
        {
            _db.Tests.Add(entity);
        }

        public void Delete(int id)
        {
            var test = _db.Tests.SingleOrDefault(x => x.Id == id);
            if (test != null)
            {
                _db.Tests.Remove(test);
            }

        }

        public List<Test> GetAll()
        {
            return _db.Tests;
        }

        public Test GetById(int id)
        {
            return _db.Tests.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Test entity)
        {
            var test = _db.Tests.SingleOrDefault(x => x.Id == entity.Id);
            if (test != null)
            {
                _db.Tests.Remove(test);
                _db.Tests.Add(entity);
            }
        }
    }
}
