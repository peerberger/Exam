using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Controllers;
using Library.Models;

namespace Exam.UserControls
{
    public interface IStudentWelcomePage
    {
        object ExamsDataSource { get; set; }
        int SelectedExam { get; set; }
        event EventHandler StartExam;
        void SetController(StudentWelcomePageController controller);

    }
}
