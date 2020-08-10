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
    public partial class Form1 : Form
    {
        Controllers.TeacherWelcomePageController controller;
        User user;
        public Form1()
        {
            InitializeComponent();
            GetUser();
            controller = new Controllers.TeacherWelcomePageController(user, welcomeTeacherViewUC1);//Setting controller to UC
        }

        private void GetUser()
        {
            using (var unit = new UnitOfWork(new DAL.ExamContext()))
            {
                user = unit.Users.GetById("321321321");
                user.Classrooms.ToList<Classroom>();
                 foreach (Classroom item in user.Classrooms)
                {
                    item.Users.ToList();
                   item.Exams
                    = unit.Exams.Find(ex => ex.ClassroomId == item.Id).ToList();
                //    foreach (var ex in examsToAdd)
                //    {
                //        item.Exams.Add(ex);
                //    }
                }
                unit.Complete();
            }
            foreach (var item in user.Classrooms)
            {
                item.Users.Remove(this.user);
            }
        }


    }
}
