using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class MockData
    {
        public static List<Models.Classroom> classrooms = new List<Models.Classroom>();
        public static List<Models.Exam> exams = new List<Models.Exam>();

        public static void LoadMocData()
        {
            Models.Classroom class1 = new Models.Classroom();
            class1.Id = 0;
            class1.Name = "Math";

            #region Math Classroom Exam1


            #region Exam 1 Questions

            Models.MultipleChoiceTextQuestion q1 = new Models.MultipleChoiceTextQuestion();
            Models.MultipleChoiceTextQuestion q2 = new Models.MultipleChoiceTextQuestion();
            Models.OpenQuestion q3 = new Models.OpenQuestion();
            Models.MultipleChoiceTextQuestion q4 = new Models.MultipleChoiceTextQuestion();
            Models.OpenQuestion q5 = new Models.OpenQuestion();

            q1.Answers.Add("16");
            q1.Answers.Add("10");
            q1.Answers.Add("18");
            q1.Answers.Add("8");
            q1.RightAnswer = 0;
            q1.QuestionText = "How much is 4*4?";
            q1.Points = 20;

            q2.Answers.Add("2x+2x");
            q2.Answers.Add("x^2+y^2");
            q2.Answers.Add("x^2+2xy+y^2");
            q2.Answers.Add("2x+2xy+2y");
            q2.RightAnswer = 2;
            q2.QuestionText = "How much is (x+y)^2";
            q2.Points = 20;

            q3.Points = 20;
            q3.QuestionDescription = "Fill in the blank";
            q3.QuestionText = "4*_=8";
            q3.RightAnswer = "2";

            q4.Answers.Add("1");
            q4.Answers.Add("2");
            q4.Answers.Add("3");
            q4.Answers.Add("4");
            q4.Answers.Add("0");
            q4.Points = 20;
            q4.QuestionText = "How much is 2/2";
            q4.RightAnswer = 0;

            q5.QuestionDescription = "Fill in the blank";
            q5.Points = 20;
            q5.QuestionText = "1_1=2";
            q5.RightAnswer = "5";

            #endregion Exam 1 Questions

            Models.Exam exam1 = new Models.Exam();
            exam1.Title = "Simple Math Test";
            exam1.Id = 0;
            exam1.ClassroomId = 0;
            exam1.Questions.Add(q1);
            exam1.Questions.Add(q2);
            exam1.Questions.Add(q3);
            exam1.Questions.Add(q4);
            exam1.Questions.Add(q5);
            exams.Add(exam1);
            #endregion

            #region Math Classroom Exam2
            #region Exam 2 Questions

            Models.MultipleChoiceTextQuestion q21 = new Models.MultipleChoiceTextQuestion();
            Models.MultipleChoiceTextQuestion q22 = new Models.MultipleChoiceTextQuestion();
            Models.OpenQuestion q23 = new Models.OpenQuestion();
            Models.MultipleChoiceTextQuestion q24 = new Models.MultipleChoiceTextQuestion();

            q21.Answers.Add("16");
            q21.Answers.Add("10");
            q21.Answers.Add("18");
            q21.Answers.Add("8");
            q21.RightAnswer = 3;
            q21.QuestionText = "How much is 2^2?";
            q21.Points = 25;

            q22.Answers.Add("2x-2x");
            q22.Answers.Add("x^2-y^2");
            q22.Answers.Add("x^2-2xy-y^2");
            q22.Answers.Add("x^2-2xy+y^2");
            q22.Answers.Add("2x+2xy+2y");
            q22.RightAnswer = 3;
            q22.QuestionText = "How much is (x+y)^2";
            q22.Points = 25;

            q23.Points = 25;
            q23.QuestionDescription = "Fill in the blank";
            q23.QuestionText = "4*_=16";
            q23.RightAnswer = "4";

            q24.Answers.Add("1");
            q24.Answers.Add("2");
            q24.Answers.Add("3");
            q24.Answers.Add("4");
            q24.Answers.Add("0");
            q24.Points = 25;
            q24.QuestionText = "How much is 4/2";
            q24.RightAnswer = 1;


            #endregion Exam 2 Questions

            Models.Exam exam2 = new Models.Exam();
            exam2.Title = "Simple Math Test2";
            exam2.Id = 1;
            exam2.ClassroomId = 0;
            exam2.Questions.Add(q21);
            exam2.Questions.Add(q22);
            exam2.Questions.Add(q23);
            exam2.Questions.Add(q24);
            exams.Add(exam2);

            #endregion

            Models.Classroom class2 = new Models.Classroom();
            class2.Id = 1;
            class2.Name = "Programming";

            #region Programming Classroom Exam3


            #region Exam 3 Questions

            Models.MultipleChoiceTextQuestion q31 = new Models.MultipleChoiceTextQuestion();
            Models.MultipleChoiceTextQuestion q32 = new Models.MultipleChoiceTextQuestion();
            Models.OpenQuestion q33 = new Models.OpenQuestion();

            q31.Answers.Add("11");
            q31.Answers.Add("9");
            q31.Answers.Add("10");
            q31.RightAnswer = 2;
            q31.QuestionText = "What is the value of b?" +
                "\n int a = 10;" +
                "\n int b =a;" +
                "a++;";
            q31.Points = 20;

            q32.Answers.Add("bool");
            q32.Answers.Add("string");
            q32.Answers.Add("int");
            q32.Answers.Add("double");
            q32.RightAnswer = 0;
            q32.QuestionText = "What varient is either true of false?";
            q33.Points = 40;

            q33.Points = 40;
            q33.QuestionDescription = "Fill in the blank";
            q33.QuestionText = "______ str = \"This is a string\"";
            q33.RightAnswer = "string";


            #endregion Exam 1 Questions

            Models.Exam exam3 = new Models.Exam();
            exam3.Title = "Simple Programming Test";
            exam3.Id = 2;
            exam3.ClassroomId = 1;
            exam3.Questions.Add(q31);
            exam3.Questions.Add(q32);
            exam3.Questions.Add(q33);
            exams.Add(exam3);


            #endregion

        }
    }
}
