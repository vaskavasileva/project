using SEDC.ESchool.DataAccess.Core.Interfaces;
using SEDC.ESchool.DataAccess.Core.Models.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.ESchool.DataAccess.Core.Repositories
{
    public class QuestionRepository : IRepository<Question>
    {
        private IStaticDb _db;
        public QuestionRepository(IStaticDb db)
        {
            _db = db;
        }
        public void Create(Question entity)
        {
            _db.Questions.Add(entity);
        }

        public void Delete(int id)
        {
            var question = _db.Questions.SingleOrDefault(x => x.Id == id);
            if (question != null)
            {
                _db.Questions.Remove(question);
            }

        }

        public List<Question> GetAll()
        {
            return _db.Questions;
        }

        public Question GetById(int id)
        {
            return _db.Questions.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Question entity)
        {
            var question = _db.Questions.SingleOrDefault(x => x.Id == entity.Id);
            if (question != null)
            {
                _db.Questions.Remove(question);
                _db.Questions.Add(entity);
            }
        }
    }
}
