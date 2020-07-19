using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Library;
using Library.Models;

namespace Exam
{
    public partial class LoginForm : Form, IAppsForms
    {
        public Controllers.LoginController Controller { get; set; }
        private EventHandler<Forms.FormEventArgs> changeForm;
        public event EventHandler<Forms.FormEventArgs> ChangeForm
        {
            add { changeForm += value; }
            remove { changeForm -= value; }
        }
        public LoginForm()
        {
            InitializeComponent();
            UserControls.LoginView.LoginUC view = new UserControls.LoginView.LoginUC();
            Controller = new Controllers.LoginController(view);
            Controller.Login += Controller_Login;
            this.Controls.Add(view);

            //using (var unitOfWork = new DAL.Repositories.UnitOfWork(new ExamContext()))
            //{
            //    unitOfWork.Classrooms.Add(new Classroom { Name = "Science" });

            //    unitOfWork.Complete();
            //}
        }

        private void Controller_Login(object sender, EventArgs e)
        {
            changeForm.Invoke(this, new Forms.FormEventArgs(sender));
        }
    }
}
