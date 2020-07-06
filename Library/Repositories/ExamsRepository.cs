using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    class ExamsRepository : IEntityFrameworkRepository<Models.Exam>
    {
        public void Delete(Exam entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Exam GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exam> GetWithRawSql(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Insert(Exam entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Exam entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
