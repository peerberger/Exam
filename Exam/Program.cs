using Exam.Forms.Student;
using Exam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositories;
using Library.Models;

namespace Exam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new QuestionPage_Student());
            MainAppController mainController = new MainAppController();
            mainController.ThisForm = new LoginForm();

            Application.Run(mainController.ThisForm as Form);

            //using (var unit = new UnitOfWork(new DAL.ExamContext()))
            //{
            //	//var u = unit.Users.GetById("123");
            //	//var exams = new List<Library.Models.Exam>();
            //	//foreach (var classroom in u.Classrooms)
            //	//{
            //	//    foreach (var item in classroom.Exams)
            //	//    {
            //	//        exams.Add(item);
            //	//    }
            //	//}
            //	//unit.Users.Remove(u);
            //	//var clas = unit.Classrooms.GetById(1);
            //	// u.Classrooms.Add(clas);
            //	//unit.Complete();


            //	//enter id + password > get user from DB
            //	//Get user -> Get classrooms -> get exams

            //	var exam = unit.Exams.GetById(1);
            //	var classrooms = unit.Users.GetById("321321321").Classrooms;

            //	unit.Complete();

            //  }
        }
    }
}
