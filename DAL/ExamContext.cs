﻿using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExamContext : DbContext
    {
        public ExamContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\DAL.ExamContext.mdf;Integrated Security=True;Connect Timeout=30")
        {

        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
						.HasMany<Classroom>(u => u.Classrooms)
						.WithMany(c => c.Users)
						.Map(cs =>
						{
							cs.MapLeftKey("UserId");
							cs.MapRightKey("ClassroomId");
							cs.ToTable("Classrooms_Users");
						});
		}
    }
}
