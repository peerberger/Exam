﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using Library;
using Library.Models;

namespace Exam.Controllers
{
    public class LoginController
    {
        UserControls.LoginView.ILoginView _view;
        Library.Models.User user = new Library.Models.User();
        public event EventHandler Login;

        public LoginController(UserControls.LoginView.ILoginView view)
        {
            this._view = view;//Setting the view instance for the controller
            _view.IdTextChanged += View_IdTextChanged;//Singing to Id text change event
            _view.LoginClicked += View_LoginClicked;//Singing to login button event
            view.SetController(this);//Setting this controller  to the view instance
        }

        //Handling Login button click
        private void View_LoginClicked(object sender, EventArgs e)
        {
            this.PreformLogin();
        }

        //Handling Id text change
        private void View_IdTextChanged(object sender, EventArgs e)
        {
            _view.Id = IdFormat(_view.Id);
        }

        //Making sure chars are numbers only and not longer than 9 digits
        public string IdFormat(string idEntered)
        {
            if (idEntered != null && idEntered != "")
            {
                char charAdded = idEntered.Last();
                if (!Char.IsNumber(charAdded) || idEntered.Length > 9)
                {
                    idEntered = idEntered.Remove(idEntered.Length - 1);
                }
            }
            return idEntered;
        }

        internal void ClearFields()
        {
            _view.Id = "";
            _view.Password = "";
        }

        public void PreformLogin()
        {
            //Check Id/Password and decide if can login or not
            //Loads User (with exam list) and passes to WelcomePage

            User user = new User();
            string enteredId = _view.Id;
            string enteredPass = _view.Password;

            using (var unit = new UnitOfWork(new DAL.ExamContext()))
            {
                user = unit.Users.GetById(enteredId);
                if (user != null)
                {
                    if (enteredPass == user.Password)
                    {
                        user.Classrooms.ToList<Classroom>();
                        foreach (var classroom in user.Classrooms)
                        {
                            //user.Exams.AddRange(unit.Exams.Find(ex => ex.ClassroomId == classroom.Id).ToList());

                            var examList = unit.Exams.Find(ex => ex.ClassroomId == classroom.Id).ToList();
                            foreach (var exam in examList)
                            {
                                user.Exams.Add(exam);
                            }
                            if (user.Role == Users.Teacher)
                            {
                                classroom.Users.ToList();
                            }
                        }
                    }
                    else
                    {
                        _view.CouldNotLogin("Incorect Password");
                        return;
                    }
                }
                else
                {
                    _view.CouldNotLogin("User Not Found");
                    return;
                }
                unit.Complete();

            }
            if (user.Role == Users.Teacher)
            {
                foreach (var classroom in user.Classrooms)
                {
                    classroom.Users.Remove(user);
                }
            }
            else if (user.Role == Users.Student)
            {
                user.UpdateExamsStatus();
            }
            Login.Invoke(user, null);
        }

        //private void LoadStudentMockData()
        //{
        //    Library.MockData.LoadMocData();
        //    this.user = new Library.Models.User();
        //    this.user.Exams = Library.MockData.exams;
        //    this.user.Role = Library.Models.Users.Student;
        //}
    }
}
