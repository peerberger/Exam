using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public interface IUnitOfWork : IDisposable
	{
		EFRepository<Exam> Exams { get; }
		EFRepository<User> Users { get; }
		EFRepository<Classroom> Classrooms { get; }

		int Complete();
	}
}
