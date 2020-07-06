using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    class QuestionsXmlRepository : IXmlRepository<Models.IQuestion>
    {
        public void Delete(IQuestion entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQuestion GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IQuestion> GetWithRawSql(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Insert(IQuestion entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IQuestion entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
