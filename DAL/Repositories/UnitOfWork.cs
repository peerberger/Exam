using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ExamContext _context;

		public EFRepository<Exam> Exams { get; private set; }
		public EFRepository<User> Users { get; private set; }
		public EFRepository<Classroom> Classrooms { get; private set; }
		public EFRepository<QImage> QImages { get; private set; }

		public UnitOfWork(ExamContext context)
		{
			_context = context;
			Exams = new EFRepository<Exam>(_context);
			Users = new EFRepository<User>(_context);
			Classrooms = new EFRepository<Classroom>(_context);
		}

		public int Complete()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}

	}
}
