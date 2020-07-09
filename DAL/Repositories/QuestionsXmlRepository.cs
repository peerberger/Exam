using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Library.Models;

namespace DAL.Repositories
{
    public class QuestionsXmlRepository : IXmlRepository<Exam>
    {
        // getting
        public Exam GetById(object id)
        {
            Exam exam = new Exam();
            var dirPath = Directory.GetCurrentDirectory();
            var filePath = Directory.GetFiles($"{dirPath}\\ExamsQuestions", $"*{id}*");
            if (filePath.Count() != 0)
            {

                var xml = XDocument.Load(filePath[0]);
                XElement elementXml = XElement.Parse(xml.ToString());
                exam.Title = elementXml.Name.ToString().Replace("_", " ");
                var questionsElement = elementXml.Elements();
                foreach (var question in questionsElement.Elements())
                {
                    if (question.Name == "MultipleChoiseTextQuestion")
                    {
                       
                        MultipleChoiceTextQuestion multipleChoise = new MultipleChoiceTextQuestion();
                        multipleChoise.QuestionText = question.Element("QuestionText").Value;
                        multipleChoise.Points = double.Parse(question.Element("Points").Value);
                        multipleChoise.RightAnswer = int.Parse(question.Element("RightAnswer").Value);
                        var answers = question.Element("Answers");
                        foreach (var answer in answers.Elements())
                        {
                            multipleChoise.Answers.Add(answer.Value);
                        }
                        exam.Questions.Add(multipleChoise);
                    }
                    else if (question.Name == "OpenQuestion")
                    {
                        OpenQuestion openQuestion = new OpenQuestion();
                        openQuestion.QuestionText = question.Element("QuestionText").Value;
                        openQuestion.Points = double.Parse(question.Element("Points").Value);
                        openQuestion.RightAnswer = question.Element("RightAnswer").Value;
                        openQuestion.QuestionDescription = question.Element("QuestionDescription").Value;
                        exam.Questions.Add(openQuestion);
                    }
                }

            }
            return exam;
        }
        
        // adding
        public void Add(Exam entity)
        {
            throw new NotImplementedException();
        }

        // removing
        public void Remove(Exam entity)
        {
            Remove(entity.Id);
        }

        public void Remove(object id)
        {
            var dirPath = Directory.GetCurrentDirectory();
            var filePath = Directory.GetFiles($"{dirPath}\\ExamsQuestions", $"*{id}*");
            if (filePath.Count() != 0)
            {
                File.Delete(filePath[0]);
            }
        }

        // updateing
        public void Update(Exam entityToUpdate)
        {
            string titleNoSpace = entityToUpdate.Title;
            foreach (var c in titleNoSpace)
            {
                titleNoSpace = titleNoSpace.Replace(" ", string.Empty);
            }
            XElement xEntity = new XElement($"{titleNoSpace}_{entityToUpdate.Id}");
            XElement xQuestions = new XElement("Questions");
            foreach (var question in entityToUpdate.Questions)
            {
                if (question is MultipleChoiceTextQuestion)
                {
                    MultipleChoiceTextQuestion multipleText = question as MultipleChoiceTextQuestion;
                    XElement xAnswers = new XElement("Answers");
                    int i = 0;
                    foreach (string answer in multipleText.Answers)
                    {
                        xAnswers.Add(new XElement($"Answer_{i}", answer));
                        i++;
                    }
                    XElement xQuestion = new XElement("MultipleChoiseTextQuestion", new object[]{
                       new XElement("QuestionText",multipleText.QuestionText),
                       xAnswers,
                       new XElement("RightAnswer",multipleText.RightAnswer),
                       new XElement("Points",multipleText.Points)
                    });
                    xQuestions.Add(xQuestion);
                }
                else if (question is OpenQuestion)
                {
                    OpenQuestion openQuestion = question as OpenQuestion;
                    XElement xQuestion = new XElement("OpenQuestion", new object[]{
                       new XElement("QuestionDescription",openQuestion.QuestionDescription),
                       new XElement("QuestionText",openQuestion.QuestionText),
                       new XElement("RightAnswer",openQuestion.RightAnswer),
                       new XElement("Points",openQuestion.Points)
                    });
                    xQuestions.Add(xQuestion);
                }
            }
            xEntity.Add(xQuestions);
            var dirPath = Directory.GetCurrentDirectory();
            string fileName = ($"{titleNoSpace}_{entityToUpdate.Id}.xml");
            if (!Directory.Exists($"{dirPath}\\ExamsQuestions"))
            {
                Directory.CreateDirectory($"{dirPath}\\ExamsQuestions");
            }
            var filePath = $"{dirPath}\\ExamsQuestions\\{fileName}";
            xEntity.Save(filePath);


            GetById(entityToUpdate.Id);
        }
    }
}
