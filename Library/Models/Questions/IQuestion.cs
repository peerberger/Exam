using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public interface IQuestion
    {
        string QuestionText { get; set; }
        double Points { get; set; }
        string QuestionDescription { get; set; }
        bool IsAnswered { get; set; }
        bool IsCorrect { get; set; }
        string RightAnswer { get; set; }
        string UserAnswer { get; set; }
        Image QuestionImage { get; set; }
    }
}
