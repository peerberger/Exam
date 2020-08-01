using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Exam.Forms.Student
{
	public partial class QuestionPage_Teacher : Form
	{
        Library.Models.Exam exam;
		public QuestionPage_Teacher()
		{
			InitializeComponent();
		}

        private void FinishButton_Click(object sender, EventArgs e)
        {
			CreateXMLFiles();

            // SAVE TO SQL
        }

		public void CreateXMLFiles()
        {
			CreateGradesFile();
			CreateQuestionsFile();
        }
        public void CreateGradesFile()
        {
            string titleNoSpace = exam.Title;
            foreach (var c in titleNoSpace)
            {
                titleNoSpace = titleNoSpace.Replace(" ", string.Empty);
            }
            string fileName = ($"{titleNoSpace}_{exam.Id}.xml");
            var filePath = SetFilePath(fileName, "ExamsGrades");

                XElement xEntity = new XElement($"{titleNoSpace}_{exam.Id}");
                xEntity.Save(filePath);
            exam.GradesPath = filePath;
        }

        public void CreateQuestionsFile()
        {
            string titleNoSpace = exam.Title;
            foreach (var c in titleNoSpace)
            {
                titleNoSpace = titleNoSpace.Replace(" ", string.Empty);
            }
            XElement xEntity = new XElement($"{titleNoSpace}_{exam.Id}");
            XElement xQuestions = new XElement("Questions");
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
            string fileName = ($"{titleNoSpace}_{exam.Id}.xml");
            var filePath = SetFilePath(fileName, "ExamsQuestions");
            xEntity.Save(filePath);
            exam.QuestionsPath = filePath;
        }


        private string SetFilePath(string fileName, string dirName)
        {
            var dirPath = Directory.GetCurrentDirectory();
            if (!Directory.Exists($"{dirPath}\\"))
            {
                Directory.CreateDirectory($"{dirPath}\\{dirName}");
            }
            var filePath = $"{dirPath}\\{dirName}\\{fileName}";
            return filePath;
        }
    }
}
