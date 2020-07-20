﻿using Exam.Forms;
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
                var loginForm = sender as LoginForm;
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
                loginForm.Hide();
                (ThisForm as WelcomePage_Student).ShowDialog();
                loginForm.Show();
            }
            if ((sender is WelcomePage_Student))
            {
                var dr = new DialogResult();
                AlertMessage alertForm = new AlertMessage();
                dr = alertForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Library.Models.Exam exam = e.DataForNextForm as Library.Models.Exam;
                    ThisForm = new QuestionPage_Student(exam);
                    (ThisForm as QuestionPage_Student).ShowDialog();
                    ThisForm = PreviousForm;
                    (ThisForm as WelcomePage_Student).welcomeController.ResetView();
                }
            }
        }

        public MainAppController()
        {

        }

        public MainAppController(IAppsForms form)
        {
            ThisForm = form;
        }



    }
}
