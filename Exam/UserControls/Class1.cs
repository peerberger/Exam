using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Models.Questions;

namespace Exam.UserControls
{
	static class Class1
	{
        static MultipleChoiceTextQuestion q1 = new MultipleChoiceTextQuestion();
        static MultipleChoiceTextQuestion q2 = new MultipleChoiceTextQuestion();

        static public MultipleChoiceTextQuestion LoadQ1()
        {
            q1.Answers.Add("16");
            q1.Answers.Add("10");
            q1.Answers.Add("18");
            q1.Answers.Add("8");
            q1.RightAnswer = "0";
            q1.QuestionText = "How much is 4*4?";
            q1.Points = 20;

            return q1;
        }
        static public MultipleChoiceTextQuestion LoadQ2()
        {
            q2.Answers.Add("2x+2x");
            q2.Answers.Add("x^2+y^2");
            q2.Answers.Add("x^2+2xy+y^2");
            q2.Answers.Add("2x+2xy+2y");
            q2.RightAnswer = "2";
            q2.QuestionText = "How much is (x+y)^2";
            q2.Points = 20;

            return q2;
        }

    }
}
