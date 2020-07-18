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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//UserControls.LoginView.LoginUC view = new UserControls.LoginView.LoginUC();
			//Controllers.LoginController controller = new Controllers.LoginController(view);
			//this.Controls.Add(view);

			using (var unitOfWork = new UnitOfWork(new ExamContext()))
			{
				//unitOfWork.Users.Add(new User { Id = "321321321", Name = "bob", Role = Users.Student, ClassroomId = 1 });

				var c = unitOfWork.Users.GetById("321321321").Classrooms;

				c.Add(unitOfWork.Classrooms.GetById(1));
				c.Add(unitOfWork.Classrooms.GetById(1002));

				//WelcomeLabel.Text = string.Empty;
				//foreach (var item in c)
				//{
				//	WelcomeLabel.Text += item.Name;
				//}

				unitOfWork.Complete();
			}
		}

	}
}
