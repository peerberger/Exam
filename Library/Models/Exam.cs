using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;
using Library.Models.Questions;

namespace Library.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ClassroomId { get; set; }
        //public Timer ExamTime { get; set; }
        public bool IsTimed { get; set; }
        public string QuestionsPath { get; set; }
        public List<IQuestion> Questions { get; set; } = new List<IQuestion>();
        [NotMapped]
        public double? FinalGrade { get; set; }
        [NotMapped]
        public bool IsAnswered { get; set; }
        public string GradesPath { get; set; }
        public int? Time { get; set; }
        

        public Exam()
        {

        }

        public Exam(int examId)
        {
            Id = examId;
            GetExam(examId);
        }

        private void GetExam(int examId)
        {

        }

        public void LoadQuestions()
        {

            string dirpath = Directory.GetCurrentDirectory();
            string filePath = dirpath + "\\" + this.QuestionsPath;
            try
            {

                var xml = XDocument.Load(filePath);
                XElement elementXml = XElement.Parse(xml.ToString());
                //   exam.Title = elementXml.Name.ToString().Replace("_", " ");
                var questionsElement = elementXml.Elements();
                foreach (var question in questionsElement.Elements())
                {
                    if (question.Name == "MultipleChoiseTextQuestion")
                    {

                        MultipleChoiceTextQuestion multipleChoise = new MultipleChoiceTextQuestion();
                        multipleChoise.QuestionText = question.Element("QuestionText").Value;
                        multipleChoise.Points = double.Parse(question.Element("Points").Value);
                        multipleChoise.RightAnswer = question.Element("RightAnswer").Value;
                        var answers = question.Element("Answers");
                        foreach (var answer in answers.Elements())
                        {
                            multipleChoise.Answers.Add(answer.Value);
                        }
                        this.Questions.Add(multipleChoise);
                    }
                    else if (question.Name == "OpenQuestion")
                    {
                        OpenQuestion openQuestion = new OpenQuestion();
                        openQuestion.QuestionText = question.Element("QuestionText").Value;
                        openQuestion.Points = double.Parse(question.Element("Points").Value);
                        openQuestion.RightAnswer = question.Element("RightAnswer").Value;
                        openQuestion.QuestionDescription = question.Element("QuestionDescription").Value;
                        this.Questions.Add(openQuestion);
                    }
                }
            }
            catch
            {

            }

        }




    }
}
