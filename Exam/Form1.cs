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
				unitOfWork.Classrooms.Add(new Classroom { Name="Occult"});

				//var users = unitOfWork.Users.GetAll();

				//unitOfWork.Users.RemoveRange(users);

				unitOfWork.Complete();
			}
		}

	}
}
