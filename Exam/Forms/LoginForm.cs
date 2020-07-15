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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserControls.LoginView.LoginUC view = new UserControls.LoginView.LoginUC();
            Controllers.LoginController controller = new Controllers.LoginController(view);
            this.Controls.Add(view);
            
            //using (var unitOfWork = new DAL.Repositories.UnitOfWork(new ExamContext()))
            //{
            //    unitOfWork.Classrooms.Add(new Classroom { Name = "Science" });

            //    unitOfWork.Complete();
            //}
        }
    }
}
