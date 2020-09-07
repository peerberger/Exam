using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAL.Repositories;
using Library.Models;
using Library.Models.Questions;

namespace DAL
{
    public static class XmlHandler
    {
        public static void CreateGradesFile(Exam exam)
        {
            string titleNoSpace = exam.Title;
            foreach (var c in titleNoSpace)
            {
                titleNoSpace = titleNoSpace.Replace(" ", string.Empty);
            }
            string fileName = ($"{titleNoSpace}_{exam.Id}.xml");
            string dirName = "ExamsGrades";
            var filePath = SetFilePath(fileName, dirName);

            XElement xEntity = new XElement($"{titleNoSpace}_{exam.Id}");
            xEntity.Save(filePath);
            exam.GradesPath = $"{dirName}\\{fileName}";
        }

        public static void CreateQuestionsFile(Exam exam)
        {
            string titleNoSpace = exam.Title;
            foreach (var c in titleNoSpace)
            {
                titleNoSpace = titleNoSpace.Replace(" ", string.Empty);
            }
            XElement xEntity = new XElement($"{titleNoSpace}_{exam.Id}");
            XElement xQuestions = new XElement("Questions");
            int index = 0;
            foreach (var question in exam.Questions)
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
                       new XElement("QuestionDescription",multipleText.QuestionDescription),
                       new XElement("QuestionText",multipleText.QuestionText),
                       xAnswers,
                       new XElement("RightAnswer",multipleText.RightAnswer),
                       new XElement("Points",multipleText.Points)
                    });
                    if (multipleText.QuestionImage != null)
                    {
                        xQuestion.Add("Image_Id", index);
                    }
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
                    if (openQuestion.QuestionImage != null)
                    {
                        xQuestion.Add("Image_Id", index);
                    }
                    xQuestions.Add(xQuestion);
                }
                index++;
            }
            xEntity.Add(xQuestions);
            //var dirPath = Directory.GetCurrentDirectory();
            string fileName = ($"{titleNoSpace}_{exam.Id}.xml");
            string dirName = "ExamsQuestions";
            var filePath = SetFilePath(fileName, dirName);
            xEntity.Save(filePath);
            exam.QuestionsPath = $"{dirName}\\{fileName}";
        }


        private static string SetFilePath(string fileName, string dirName)
        {
            var dirPath = Directory.GetCurrentDirectory();
            if (!Directory.Exists($"{dirPath}\\{dirName}"))
            {
                Directory.CreateDirectory($"{dirPath}\\{dirName}");
            }
            var filePath = $"{dirPath}\\{dirName}\\{fileName}";
            return filePath;
        }

        public static void LoadExamQuestions(Exam exam)
        {
            string dirpath = Directory.GetCurrentDirectory();
            string filePath = dirpath + "\\" + exam.QuestionsPath;
            try
            {
                var xml = XDocument.Load(filePath);
                XElement elementXml = XElement.Parse(xml.ToString());
                //   exam.Title = elementXml.Name.ToString().Replace("_", " ");
                var questionsElement = elementXml.Elements();
                foreach (var xQuestion in questionsElement.Elements())
                {
                    IQuestion question;
                    if (xQuestion.Name == "MultipleChoiseTextQuestion")
                    {
                        question = new MultipleChoiceTextQuestion();
                        var answers = xQuestion.Element("Answers");
                        foreach (var answer in answers.Elements())
                        {
                            (question as MultipleChoiceTextQuestion).Answers.Add(answer.Value);
                        }
                    }
                    else
                    {
                        question = new OpenQuestion();
                    }
                    question.Points = double.Parse(xQuestion.Element("Points").Value);
                    question.RightAnswer = xQuestion.Element("RightAnswer").Value;
                    question.QuestionDescription = xQuestion.Element("QuestionDescription").Value;
                    question.QuestionText = xQuestion.Element("QuestionText").Value;
                    if (xQuestion.Element("Image_Id") != null)
                    {
                        using (var unit = new UnitOfWork(new ExamContext()))
                        {
                            int imageId = int.Parse(xQuestion.Element("Image_Id").Value);
                            QImage qImgModel = unit.QImages
                                .Find(img => (img.ExamId == exam.Id) && (img.Id == imageId))
                                .ToList()[0];
                            question.QuestionImage = ByteArrayToImage(qImgModel.QuestionImage);
                        }
                    }
                    exam.Questions.Add(question);
                }
            }
            catch
            {

            }

        }
        // from https://stackoverflow.com/questions/25400555/save-and-retrieve-image-binary-from-sql-server-using-entity-framework-6
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
        	using (var ms = new MemoryStream(byteArrayIn))
        	{
        		var returnImage = Image.FromStream(ms);
        		return returnImage;
        	}
        }
    }
}
