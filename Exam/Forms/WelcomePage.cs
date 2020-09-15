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
    public partial class WelcomePage : Form, IAppsForms
    {
        public IWelcomePageController welcomeController;
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

        public WelcomePage()
        {
            InitializeComponent();

            //using (var unitOfWork = new UnitOfWork(new ExamContext()))
            //{
            //    unitOfWork.Classrooms.Add(new Classroom { Name = "Science" });

            //    unitOfWork.Complete();
            //}
        }

        public WelcomePage(User user) : this()
        {
            if(user.Role == Users.Teacher)
            {
                //Setting controller to UC
                WelcomeTeacherViewUC view = new WelcomeTeacherViewUC();
                SetViewToForm(view);
                TeacherWelcomePageController controller = new Controllers.TeacherWelcomePageController(user, view);
                controller.BuildExam += Controller_BuildExam;
            }
            else if (user.Role == Users.Student)
            {
                WelcomeStudentViewUC view = new WelcomeStudentViewUC();
                SetViewToForm(view);
                StudentWelcomePageController controller = new StudentWelcomePageController(user, view);
                controller.StartExam += WelcomeController_StartExam;
                welcomeController = controller;
            }

        }

        private void SetViewToForm(WelcomeView view)
        {
            view.Location = new System.Drawing.Point(3, 128);
            view.Name = "WelcomeSView";
            view.Size = new System.Drawing.Size(794, 319);
            view.TabIndex = 3;
            this.TableLayout.Controls.Add(view, 0, 1);
        }

        private void Controller_BuildExam(object sender, EventArgs e)
        {
            changeForm.Invoke(this, new FormEventArgs(sender));
        }

        private void WelcomeController_StartExam(object sender, EventArgs e)
        {
            changeForm.Invoke(this, new FormEventArgs(sender));
        }

        public void FormShowDialog()
        {
            this.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

