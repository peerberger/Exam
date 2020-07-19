using Exam.Forms;
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
           
            if (sender is LoginForm)
            {
                User user = e.DataForNextForm as User;
                if (user.Role == Users.Admin)
                {
                    //Open Admin Page
                }
                else if (user.Role == Users.Teacher)
                {
                    //Open Teacher Page
                }
                else if (user.Role == Users.Student)
                {
                    WelcomePage_Student newForm = new WelcomePage_Student(user);
                    ThisForm = newForm;
                }
            (ThisForm as WelcomePage_Student).Show();
            (PreviousForm as Form).Close();
            }



        }

        public event EventHandler<FormEventArgs> OpenNewForm;


        public MainAppController()
        {

        }

        public MainAppController(IAppsForms form)
        {
            ThisForm = form;
        }



    }
}
