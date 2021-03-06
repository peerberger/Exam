﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class EFRepository<TEntity> : IEFRepository<TEntity> where TEntity : class
	{
		protected readonly DbContext _context;

		public EFRepository(DbContext context)
		{
			_context = context;
		}

		// getting
		public TEntity GetById(object id)
		{
			return _context.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _context.Set<TEntity>().ToList();
		}

		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
		{
			return _context.Set<TEntity>().Where(predicate);
		}

		// adding
		public void Add(TEntity entity)
		{
			_context.Set<TEntity>().Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			_context.Set<TEntity>().AddRange(entities);
		}

		// removing
		public void Remove(TEntity entity)
		{
			_context.Set<TEntity>().Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			_context.Set<TEntity>().RemoveRange(entities);
		}
	}
}
