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
        private StudentWelcomePageController welcomeController;
        private User user;
        public WelcomePage_Student()
        {
            //Loading mock data to user 
            //needs to be passed from login
           // LoadStudentMockData();
            
            InitializeComponent();
            welcomeController =
          new StudentWelcomePageController(user, studentWelcomePageUC);

            //using (var unitOfWork = new UnitOfWork(new ExamContext()))
            //{
            //    unitOfWork.Classrooms.Add(new Classroom { Name = "Science" });

            //    unitOfWork.Complete();
            //}
        }

        public WelcomePage_Student(User user)
        {
            InitializeComponent();
            this.user = user;
            new StudentWelcomePageController(user, studentWelcomePageUC);
        }

        public event EventHandler<FormEventArgs> ChangeForm;

        //private void LoadStudentMockData()
        //{
        //    Library.MockData.LoadMocData();
        //    this.user = new User();
        //    this.user.Exams = Library.MockData.exams;
        //}
    }
}
