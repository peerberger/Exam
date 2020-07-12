using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
	public class ExamContext : DbContext
	{
		public ExamContext() : base("ExamContext")//@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ExamDB.mdf;Integrated Security=True;Connect Timeout=30")
		{
			
		}
		
		public DbSet<Exam> Exams { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Classroom> Classrooms { get; set; }
	}
}
