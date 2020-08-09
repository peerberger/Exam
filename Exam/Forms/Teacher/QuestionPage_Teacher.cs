using DAL.Repositories;
using Exam.UserControls;
using Library.Models;
using Library.Models.Questions;
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
		private Library.Models.Exam exam = new Library.Models.Exam();
		private int currQuestionIndex = 0;

		public int CurrQuestionIndex
		{
			get { return currQuestionIndex; }
			set
			{
				if (value == 0)
				{
					PreviousButton.Enabled = false;
				}
				else
				{
					PreviousButton.Enabled = true;
				}

				QuestionNumberLabel.Text = $"{value + 1} / {exam.Questions.Count}";

				currQuestionIndex = value;
			}
		}


		public QuestionPage_Teacher()
		{
			InitializeComponent();

			LoadClassroomsComboBox("1");

			exam.Questions.Add(new Question());
		}

		#region Saar's
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
		#endregion

		#region Peer's
		private void NextButton_Click(object sender, EventArgs e)
		{
			if (CurrQuestionIndex == exam.Questions.Count - 1)
			{
				UpdateCurrQuestion();
				QuestionBuilder.Reset();

				exam.Questions.Add(new Question());

				CurrQuestionIndex++;
			}
			else
			{
				UpdateCurrQuestion();

				CurrQuestionIndex++;
				LoadCurrQuestion();

				if (CurrQuestionIndex == exam.Questions.Count - 1)
				{
					NextButton.Text = "New Question";
				}
			}
		}

		private void UpdateCurrQuestion()
		{
			if (QuestionBuilder.QuestionTypeMultiple)
			{
				exam.Questions[CurrQuestionIndex] = new MultipleChoiceTextQuestion();
				(exam.Questions[CurrQuestionIndex] as MultipleChoiceTextQuestion).Answers = QuestionBuilder.Answers;
			}
			else
			{
				exam.Questions[CurrQuestionIndex] = new OpenQuestion();
			}

			exam.Questions[CurrQuestionIndex].QuestionDescription = QuestionBuilder.Description;
			exam.Questions[CurrQuestionIndex].QuestionText = QuestionBuilder.QuestionText;
			exam.Questions[CurrQuestionIndex].RightAnswer = QuestionBuilder.RightAnswer;
		}

		private void PreviousButton_Click(object sender, EventArgs e)
		{
			UpdateCurrQuestion();

			if (CurrQuestionIndex == exam.Questions.Count - 1)
			{
				NextButton.Text = "Next";
			}

			CurrQuestionIndex--;
			LoadCurrQuestion();
		}

		private void LoadCurrQuestion()
		{
			var currQuestion = exam.Questions[CurrQuestionIndex] as IQuestion;

			if (currQuestion is MultipleChoiceTextQuestion)
			{
				QuestionBuilder.PopulateAnswers((currQuestion as MultipleChoiceTextQuestion).Answers);
				QuestionBuilder.QuestionTypeMultiple = true;
			}
			else
			{
				QuestionBuilder.QuestionTypeOpen = true;
			}

			QuestionBuilder.Description = currQuestion.QuestionDescription;
			QuestionBuilder.QuestionText = currQuestion.QuestionText;
			QuestionBuilder.RightAnswer = currQuestion.RightAnswer;
		}

		private void LoadClassroomsComboBox(string teacherId)
		{
			using (var unit = new UnitOfWork(new DAL.ExamContext()))
			{
				List<Classroom> classrooms = unit.Users.GetById(teacherId).Classrooms.ToList();
				ClassroomsComboBox.ValueMember = "Id";
				ClassroomsComboBox.DisplayMember = "Name";
				ClassroomsComboBox.DataSource = classrooms;

				unit.Complete();
			}
		}

		private void TitleTextBox_TextChanged(object sender, EventArgs e)
		{
			exam.Title = TitleTextBox.Text;
		}

		private void ClassroomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			exam.ClassroomId = (int)ClassroomsComboBox.SelectedValue;
		}
		#endregion

	}
}
