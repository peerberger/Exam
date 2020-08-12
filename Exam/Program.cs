using Exam.Forms.Student;
using Exam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositories;
using Library.Models;
using Exam.Forms;
using System.IO;

namespace Exam
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//// Application.Run(new QuestionPage_Student());
			//MainAppController mainController = new MainAppController();
			//mainController.ThisForm = new LoginForm();

			//Application.Run(mainController.ThisForm as Form);

			// Application.Run(new Form1());

			// convert the questionBuilder into MVC
			// merge all the forms of the app together - via MainController
			// write xml code in the ExamBuilder and the WelcomePage (both teacher and student)

			// add image


			RepopulateUsers();
			RepopulateClassrooms();
			AssignUsersToClassooms();
		}

		private static Random rand = new Random();

		static void RepopulateUsers()
		{
			using (var unit = new UnitOfWork(new DAL.ExamContext()))
			{
				var users = unit.Users.GetAll();
				unit.Users.RemoveRange(users);

				List<User> usersToAdd = new List<User>
				{
					// teachers
					new User { Id="000000001", Name="Patrick Star", Password="0101", Role=Users.Teacher},
					new User { Id="000000002", Name="Miss Frizzle", Password="0202", Role=Users.Teacher},

					// students
					new User { Id="000000003", Name="North West", Password="0303", Role=Users.Student},
					new User { Id="000000004", Name="Renesme Swan", Password="0404", Role=Users.Student},
					new User { Id="000000005", Name="X AE A-12 Musk", Password="0505", Role=Users.Student},
					new User { Id="000000006", Name="Juno Gasai", Password="0606", Role=Users.Student},
					new User { Id="000000007", Name="Danny Phantom", Password="0707", Role=Users.Student},
					new User { Id="000000008", Name="Jake Long", Password="0808", Role=Users.Student},
					new User { Id="000000009", Name="Ella Lee", Password="0909", Role=Users.Student},
					new User { Id="000000010", Name="Hannah Montana", Password="1010", Role=Users.Student},
					new User { Id="000000011", Name="Bob Sphogue", Password="1111", Role=Users.Student}
				};

				unit.Users.AddRange(usersToAdd);

				unit.Complete();
			}
		}

		static void RepopulateClassrooms()
		{
			using (var unit = new UnitOfWork(new DAL.ExamContext()))
			{
				var classrooms = unit.Classrooms.GetAll();
				unit.Classrooms.RemoveRange(classrooms);

				List<Classroom> classroomsToAdd = new List<Classroom>
				{
					new Classroom {Name="Science"},
					new Classroom {Name="Rap"},
					new Classroom {Name="Philosophy"}
				};

				unit.Classrooms.AddRange(classroomsToAdd);

				unit.Complete();
			}
		}

		static void AssignUsersToClassooms()
		{
			using (var unit = new UnitOfWork(new DAL.ExamContext()))
			{
				List<User> teachers = unit.Users.Find(u => u.Role == Users.Teacher).ToList();
				List<User> students = unit.Users.Find(u => u.Role == Users.Student).ToList();
				List<Classroom> classrooms = unit.Classrooms.GetAll().ToList();

				for (int i = 0; i < classrooms.Count; i++)
				{
					var teacherClassrooms = teachers[i % teachers.Count].Classrooms;

					teacherClassrooms.Add(classrooms[i]);
				}

				// some students might not get assigned a class

				foreach (var student in students)
				{
					var studentClassrooms = student.Classrooms;

					studentClassrooms.Add(classrooms[rand.Next(classrooms.Count)]);

					if (rand.Next(2) == 1)
					{
						studentClassrooms.Add(classrooms[rand.Next(classrooms.Count)]);
					}
				}

				unit.Complete();
			}
		}
	}
}
