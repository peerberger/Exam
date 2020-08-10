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
    public class TeacherWelcomePageController : IWelcomePageController
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
            UpdateStudentsGradesList();
        }

        private void UpdateStudentsGradesList()
        {
            List<string> grades = GetGrades();

            var list = new List<Tuple<string, string>>().Select
                (t => new { Student = t.Item1, Grade = t.Item2 }).ToList();
            int index = 0;

            foreach (var student in selectedClass.Users)
            {
                list.Add(new { Student = student.Name, Grade = grades[index] });
                index++;
            }
            list = list.OrderBy(x => x.Student).ToList();
            _view.StudentsDataSource = list;
        }

        private List<string> GetGrades()
        {
            //Getting Grades XML
            List<string> grades = new List<string>();
            var exam = selectedClass.Exams[_view.SelectedExam];
            string dirpath = Directory.GetCurrentDirectory();
            string gradesPath = $"{dirpath}\\{exam.GradesPath}";

            //Reading From XML
            var examXMLStr = File.ReadAllText(gradesPath);
            var examXML = XElement.Parse(examXMLStr);
            foreach (User student in selectedClass.Users)
            {
                //Getting grade of each student
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
            return grades;
        }

        private void _view_SelectedClassChanged(object sender, EventArgs e)
        {
            int selectedClassroom = _view.SelectedClass;
            selectedClass = user.Classrooms.ElementAt(selectedClassroom);
            UpdateExamListView();
        }

        private void UpdateExamListView()
        {
            List<string> examsList = new List<string>();
            foreach (Library.Models.Exam exam in selectedClass.Exams)
            {
                examsList.Add(exam.Title);
            }
            _view.ExamsDataSource = examsList;
        }


        private void _view_BuildExam(object sender, EventArgs e)
        {
            BuildExam.Invoke(user, null);
        }

        public void ResetView()
        {
            throw new NotImplementedException();
        }
    }
}
