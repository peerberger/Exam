using Exam.Forms.Student;
using Exam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositories;
using Library.Models;
using Exam.Forms;
using System.IO;

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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //// Application.Run(new QuestionPage_Student());
            //MainAppController mainController = new MainAppController();
            //mainController.ThisForm = new LoginForm();

            //Application.Run(mainController.ThisForm as Form);

            Application.Run(new Form1());

            // convert the questionBuilder into MVC
            // merge all the forms of the app together - via MainController
            // write xml code in the ExamBuilder and the WelcomePage (both teacher and student)

            // add image
        }
    }
}
