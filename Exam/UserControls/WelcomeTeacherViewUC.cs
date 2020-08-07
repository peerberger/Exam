using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositories;
using Library.Models;
using System.Data.Entity.Infrastructure;

namespace Exam.UserControls
{
	public partial class WelcomeTeacherViewUC : UserControl
	{
		public int SelectedClassroomId
		{
			get { return (int)ClassroomsComboBox.SelectedValue; }
		}


		public WelcomeTeacherViewUC()
		{
			InitializeComponent();

			LoadClassroomsComboBox("1");


		}

		private void LoadClassroomsComboBox(string teacherId)
		{
			using (var unit = new UnitOfWork(new DAL.ExamContext()))
			{
				List<Classroom> classrooms = unit.Users.GetById(teacherId).Classrooms.ToList();
				ClassroomsComboBox.ValueMember = "Id";
				ClassroomsComboBox.DisplayMember = "Name";
				ClassroomsComboBox.DataSource = classrooms;

				unit.Complete();
			}
		}

		private void LoadExamsComboBox(int classroomId)
		{
			using (var unit = new UnitOfWork(new DAL.ExamContext()))
			{
				List<Library.Models.Exam> exams = unit.Exams.Find(e => e.ClassroomId == classroomId).ToList();
				ExamsComboBox.ValueMember = "Id";
				ExamsComboBox.DisplayMember = "Title";
				ExamsComboBox.DataSource = exams;

				unit.Complete();
			}
		}

		private void ClassroomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadExamsComboBox(SelectedClassroomId);
		}

		private void ExamsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			using (var unit = new UnitOfWork(new DAL.ExamContext()))
			{
				var students = unit.Classrooms.GetById(SelectedClassroomId).Users.Where(u => u.Role == Users.Student).Select(u=> new { id = u.Id, name = u.Name}).ToList();

				//TODO:
				// get grades from exam

				// populate GradesGridView

				//GradesGridView.Columns["Student"].DataPropertyName = "name";
				//GradesGridView.AutoGenerateColumns = false;
				//GradesGridView.DataSource = students;

				unit.Complete();
			}
		}
	}
}
