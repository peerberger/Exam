using Exam.UserControls.TeacherWelcome;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Controllers
{
    public class TeacherWelcomePageController
    {
        public User user;
        private ITeacherWelcomeView _view;
        //public event EventHandler SelectedExamChanged;
        // public event EventHandler SelectedClassChanged;
        public event EventHandler BuildExam;

        public TeacherWelcomePageController(User user, ITeacherWelcomeView view)
        {
            this.user = user;

            _view = view;
            _view.SetController(this);
            _view.BuildExam += _view_BuildExam;
            _view.SelectedClassChanged += _view_SelectedClassChanged;
            _view.SelectedExamChanged += _view_SelectedExamChanged;
            InitializeViewClassrooms();
        }

        private void InitializeViewClassrooms()
        {
            List<string> classroomsList = new List<string>();
            foreach (Classroom classroom in user.Classrooms)
            {
                classroomsList.Add(classroom.Name);
            }
            _view.ClassroomsDataSource = classroomsList;
        }

        private void _view_SelectedExamChanged(object sender, EventArgs e)
        {
            int selectedExam = _view.SelectedExam;
            UpdateStudentsList();
        }

        private void UpdateStudentsList()
        {
            throw new NotImplementedException();
        }

        private void _view_SelectedClassChanged(object sender, EventArgs e)
        {
            int selectedClassroom = _view.SelectedClass;
            UpdateExamListView(selectedClassroom);
        }

        private void UpdateExamListView(int selectedClassroom)
        {
            List<string> examsList = new List<string>();
           // List<Classroom> classrooms = user.Classrooms as List<Classroom>;
            Classroom classroom = user.Classrooms.ElementAt(selectedClassroom);
            foreach (Library.Models.Exam exam in classroom.Exams)
            {
                examsList.Add(exam.Title);
            }
            _view.ExamsDataSource = examsList;
        }


        private void _view_BuildExam(object sender, EventArgs e)
        {
            BuildExam.Invoke(this, null);
        }
    }
}
