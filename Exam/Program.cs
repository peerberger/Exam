using Exam.Forms.Student;
﻿using Exam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
