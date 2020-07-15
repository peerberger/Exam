using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class MultipleChoiceQuestion : IQuestion
    {
        public string RightAnswer { get; set; }
        public string QuestionText { get; set; }
        public double Points { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
        public string QuestionDescription { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsCorrect { get; set; }

        public MultipleChoiceQuestion()
        {
            QuestionDescription = "Select the correct answer";
        }


    }
}
