using DAL;
using DAL.Repositories;
using Exam.Controllers;
using Exam.Forms;
using Exam.UserControls;
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
    public partial class WelcomePage_Student : Form, IAppsForms
    {
        public StudentWelcomePageController welcomeController;
        private EventHandler<FormEventArgs> changeForm;
        public event EventHandler<FormEventArgs> ChangeForm
        {
            add
            {
                if (changeForm == null)
                {
                    changeForm += value;
                }
            }
            remove { changeForm -= value; }
        }

        public WelcomePage_Student()
        {
            InitializeComponent();

            //using (var unitOfWork = new UnitOfWork(new ExamContext()))
            //{
            //    unitOfWork.Classrooms.Add(new Classroom { Name = "Science" });

            //    unitOfWork.Complete();
            //}
        }

        public WelcomePage_Student(User user) : this()
        {
            welcomeController =
            new StudentWelcomePageController(user, WelcomeStudentView);
            welcomeController.StartExam += WelcomeController_StartExam;
        }

        private void WelcomeController_StartExam(object sender, EventArgs e)
        {
            changeForm.Invoke(this, new FormEventArgs(sender));
        }
    }
}
