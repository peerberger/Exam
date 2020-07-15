using DAL;
using DAL.Repositories;
using Exam.Controllers;
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
    public partial class WelcomePage_Student : Form
    {
        private StudentWelcomePageController welcomeController;
        private User user;
        public WelcomePage_Student()
        {
            LoadStudentMockData();
            InitializeComponent();
            welcomeController =
          new StudentWelcomePageController(user, studentWelcomePageUC);

            //using (var unitOfWork = new UnitOfWork(new ExamContext()))
            //{
            //    unitOfWork.Classrooms.Add(new Classroom { Name = "Science" });

            //    unitOfWork.Complete();
            //}
        }


        private void LoadStudentMockData()
        {
            Library.MockData.LoadMocData();
            this.user = new User();
            this.user.Exams = Library.MockData.exams;
        }
    }
}
