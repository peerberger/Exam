namespace DAL.Repositories
{
	public interface IRepository<TEntity> where TEntity : class
	{
		// getting
		TEntity GetById(object id);

		// adding
		void Add(TEntity entity);

		// removing
		void Remove(TEntity entity);
	}
}