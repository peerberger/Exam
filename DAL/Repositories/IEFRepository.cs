using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public interface IEFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
		// getting
		IEnumerable<TEntity> GetAll();
		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

		// adding
		void AddRange(IEnumerable<TEntity> entities);

		// removing
		void RemoveRange(IEnumerable<TEntity> entities);
    }
}
