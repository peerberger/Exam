using Exam.UserControls.TeacherWelcome;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam.Controllers
{
    public class TeacherWelcomePageController
    {
        private Classroom selectedClass;
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
            UpdateStudentsGradesList();
        }

        private void UpdateStudentsGradesList()
        {
            GetMockGrades();
        }

        private void GetMockGrades()
        {
            List<string> grades = new List<string>();
            string dirpath = Directory.GetCurrentDirectory();
            string gradesPath = $"{dirpath}\\ExamsGrades\\TestExam_10.xml";
            var examXMLStr = File.ReadAllText(gradesPath);
            var examXML = XElement.Parse(examXMLStr);
            foreach (User student in selectedClass.Users)
            {
                var studentElement = examXML.Elements("Student").
                    Where(x => x.Element("ID").Value.Equals(student.Id)).ToList();
                if (studentElement.Count != 0)
                {
                    string grade = double.Parse(studentElement[0].Element("Grade").Value).ToString();
                    grades.Add(grade);
                }
                else
                {
                    grades.Add("Unanswered");
                }
            }
            TestShowStudents(grades);
        }

        private void TestShowStudents(List<string> grades)
        {
            var list = new List<Tuple<string, string>>().Select(t => new { Student = t.Item1, Grade = t.Item2 }).ToList();
            int selectedClassroom = _view.SelectedClass;
            selectedClass = user.Classrooms.ElementAt(selectedClassroom);
            int index = 0;

            foreach (var student in selectedClass.Users)
            {
                list.Add(new { Student = student.Name, Grade = grades[index] });
                index++;
            }

            _view.StudentsDataSource = list;
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
            selectedClass = user.Classrooms.ElementAt(selectedClassroom);
            foreach (Library.Models.Exam exam in selectedClass.Exams)
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
