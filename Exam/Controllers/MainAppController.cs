using DAL.Repositories;
using Exam.Forms;
using Exam.Forms.Student;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Controllers
{
    public class MainAppController
    {
        private User user;
        private IAppsForms _thisForm;
        public IAppsForms PreviousForm { get; set; }
        public IAppsForms ThisForm
        {
            get { return _thisForm; }
            set
            {
                PreviousForm = _thisForm;
                _thisForm = value;

                _thisForm.ChangeForm += _thisForm_ChangeForm;
            }
        }

        private void _thisForm_ChangeForm(object sender, FormEventArgs e)
        {
            if (sender is LoginForm)// Login -> Welcome
            {
                var loginForm = sender as LoginForm;
                user = e.DataForNextForm as User;
                WelcomePage newForm = new WelcomePage(user);
                ThisForm = newForm;
                loginForm.Hide();
                (ThisForm as Form).ShowDialog();//Opening Welcome page as dialog
                loginForm.Show();//Re-opening the login after welcome page closes
                loginForm.ClearFields();
            }
            if ((sender is WelcomePage) && user.Role == Users.Student)//Welcome-Student -> Alert -> Exam
            {
                var dr = new DialogResult();
                string alertString = "By clicking OK you will start the test.You Will not be able to go back without finishing.";
                AlertMessage alertForm = new AlertMessage(alertString);
                dr = alertForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //Opening the exam - QuestionPage_Student
                    Library.Models.Exam exam = e.DataForNextForm as Library.Models.Exam;
                    ThisForm = new QuestionPage_Student(exam);
                    ThisForm.FormShowDialog();
                    user.UpdateExamGradeXML(exam);
                    ThisForm = PreviousForm;
                    (ThisForm as WelcomePage).welcomeController.ResetView();
                }
            }
            else if ((sender is WelcomePage) && user.Role == Users.Teacher)//Welcome-Teacher -> Build Exam
            {
                User teacher = e.DataForNextForm as User;
                ThisForm = new QuestionPage_Teacher(teacher);
                ThisForm.FormShowDialog();
            }
        }

        public MainAppController()
        {

        }

        public MainAppController(IAppsForms form)
        {
            ThisForm = form;
        }

        //private void SetExamsToUser()
        //{
        //    foreach (var classroom in user.Classrooms)
        //    {
        //        using (var unit = new UnitOfWork(new DAL.ExamContext()))
        //        {
        //            List<Library.Models.Exam> examsToAdd
        //                = unit.Exams.Find(ex => ex.ClassroomId == classroom.Id).ToList();
        //            foreach (var ex in examsToAdd)
        //            {
        //                user.AddToExams(ex);
        //            }
        //            unit.Complete();
        //        }
        //    }
        //}

    }
}
