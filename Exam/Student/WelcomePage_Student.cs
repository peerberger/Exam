using DAL;
using DAL.Repositories;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
	public partial class WelcomePage_Student : Form
	{
		public WelcomePage_Student()
		{
			InitializeComponent();

			using (var unitOfWork = new UnitOfWork(new ExamContext()))
			{
				Classroom c = unitOfWork.Classrooms.GetById(2);

				unitOfWork.Classrooms.Remove(c);

				unitOfWork.Complete();
			}
		}
	}
}
