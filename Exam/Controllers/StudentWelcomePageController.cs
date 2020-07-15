using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.UserControls;
using Library;
using Library.Models;

namespace Exam.Controllers
{
    public class StudentWelcomePageController
    {
        private User user;
        private IStudentWelcomePage _view;
        public StudentWelcomePageController(User user, IStudentWelcomePage view)
        {
            this.user = user;
            _view = view;
            _view.SetController(this);
            SetExamsToView();
            _view.StartExam += _view_StartExam;
        }

        private void _view_StartExam(object sender, EventArgs e)
        {
            QuestionPage_Student questionfrm = new QuestionPage_Student(user.Exams[_view.SelectedExam]);
            questionfrm.Show();
        }

        private void SetExamsToView()
        {
            var list =new List<Tuple<string, string>>().Select(t=> new { Exam = t.Item1, Grade = t.Item2 }).ToList();
            foreach (Library.Models.Exam exam in user.Exams)
            {
                if(exam.IsAnswered)
                {
                   list.Add(new {Exam =  exam.Title.ToString(),Grade = exam.FinalGrade.ToString()});
                }
                else
                {
                   list.Add(new {Exam =  exam.Title.ToString(),Grade = "Unanswered"});
                }
            }
            _view.ExamsDataSource = list;
        }



    }
}
