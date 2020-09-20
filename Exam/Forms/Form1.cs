using DAL.Repositories;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Forms
{
    public partial class Form1 : Form, IAppsForms
    {
        Controllers.TeacherWelcomePageController controller;
        User user;

        private EventHandler<FormEventArgs> changeForm;
        public event EventHandler<FormEventArgs> ChangeForm
        {
            add { changeForm += value; }
            remove { changeForm -= value; }
        }

        public Form1()
        {
            InitializeComponent();
            GetUser();
            controller = new Controllers.TeacherWelcomePageController(user, welcomeTeacherViewUC1);//Setting controller to UC
            controller.BuildExam += Controller_BuildExam;
        }


        private void Controller_BuildExam(object sender, EventArgs e)
        {
            changeForm.Invoke(this, new FormEventArgs(sender));
        }

        private void GetUser()
        {
            using (var unit = new UnitOfWork(new DAL.ExamContext()))
            {
                //Mock User
                user = unit.Users.GetById("321321321");
                user.Classrooms.ToList<Classroom>();
                foreach (Classroom item in user.Classrooms)
                {
                    item.Users.ToList();
                    item.Exams
                     = unit.Exams.Find(ex => ex.ClassroomId == item.Id).ToList();
                }
                unit.Complete();
            }
            foreach (var item in user.Classrooms)
            {
                item.Users.Remove(this.user);
            }
        }

        public void FormShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
