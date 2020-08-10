using Exam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.UserControls.TeacherWelcome
{
    public interface ITeacherWelcomeView
    {
        object ExamsDataSource { get; set; }
        object ClassroomsDataSource { get; set; }
        object StudentsDataSource { get; set; }

        int SelectedExam { get; set; }
        int SelectedClass { get; set; }

        event EventHandler BuildExam;
        event EventHandler SelectedExamChanged;
        event EventHandler SelectedClassChanged;
        void SetController(TeacherWelcomePageController controller);
    }
}
