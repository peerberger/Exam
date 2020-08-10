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
using Exam.UserControls.TeacherWelcome;
using Exam.Controllers;

namespace Exam.UserControls
{
	public partial class WelcomeTeacherViewUC : UserControl, ITeacherWelcomeView
	{
		private TeacherWelcomePageController _controller;

		public object ExamsDataSource
		{
			get => ExamsComboBox.DataSource;
			set => ExamsComboBox.DataSource = value;
		}
		public object ClassroomsDataSource 
		{
			get => ClassroomsComboBox.DataSource;
			set => ClassroomsComboBox.DataSource = value;
		}
        public object StudentsDataSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
		public int SelectedExam
		{
			get => ExamsComboBox.SelectedIndex;
			set => ExamsComboBox.SelectedIndex = value;
		}
		public int SelectedClass 
		{ 
			get => ClassroomsComboBox.SelectedIndex;
			set=> ClassroomsComboBox.SelectedIndex= value;
		}

		private EventHandler selectedExamChanged;
		public event EventHandler SelectedExamChanged
		{
			add	{selectedExamChanged += value;}
			remove	{selectedExamChanged -= value;}
		}

		private EventHandler selectedClassChanged;
		public event EventHandler SelectedClassChanged
		{
			add { selectedClassChanged += value; }
			remove { selectedClassChanged -= value; }
		}

		private EventHandler buildExam;
		public event EventHandler BuildExam
		{
			add { buildExam += value; }
			remove { buildExam -= value; }
		}

		public WelcomeTeacherViewUC()
		{
			InitializeComponent();

			//LoadClassroomsComboBox("1");


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
			//LoadExamsComboBox(SelectedClassroomId);
			SelectedClass = ClassroomsComboBox.SelectedIndex;
			selectedClassChanged.Invoke(this,null);

		}

		private void ExamsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedExamChanged.Invoke(this, null);
			//using (var unit = new UnitOfWork(new DAL.ExamContext()))
			//{
			//	var students = unit.Classrooms.GetById(SelectedClassroomId).Users.Where(u => u.Role == Users.Student).Select(u=> new { id = u.Id, name = u.Name}).ToList();

			//	//TODO:
			//	// get grades from exam

			//	// populate GradesGridView

			//	//GradesGridView.Columns["Student"].DataPropertyName = "name";
			//	//GradesGridView.AutoGenerateColumns = false;
			//	//GradesGridView.DataSource = students;

			//	unit.Complete();
			//}
		}

        public void SetController(TeacherWelcomePageController controller)
        {
			this._controller = controller;
        }

        private void BuildTestButton_Click(object sender, EventArgs e)
        {
			buildExam.Invoke(this, null);
        }
    }
}
