using DAL.Repositories;
using Exam.Controllers;
using Exam.UserControls;
using Library.Models;
using Library.Models.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DAL;

namespace Exam.Forms.Student
{
	//TODO
	//The Correct Answer isn't added to the options
	public partial class QuestionPage_Teacher : Form, IAppsForms
	{
		private bool isFinished = false;

		private QuestionBuilderController controller;
		int selectedClassroom;
		private User user;
		private Library.Models.Exam exam = new Library.Models.Exam();
		private int currQuestionIndex = 0;
		private EventHandler<FormEventArgs> changeForm;
		public event EventHandler<FormEventArgs> ChangeForm
		{
			add { changeForm += value; }
			remove { changeForm -= value; }
		}

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
			this.FormClosing += QuestionPage_Teacher_FormClosing;
			exam.Questions.Add(new Question());
		}

		//LoadClassroomsComboBox("000000001");
		
		private void QuestionPage_Teacher_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isFinished)
			{
				var dr = new DialogResult();
				string alertString = "By clicking OK you will exit the test builder.\r\n " +
											 "Your test will not be saved!";
				AlertMessage alertForm = new AlertMessage(alertString);
				dr = alertForm.ShowDialog();
				if (dr == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
			}
		}

		public QuestionPage_Teacher(User user) : this()
		{
			this.user = user;
			controller = new QuestionBuilderController(user, QuestionBuilder);
			LoadClassroomsComboBox(); // needs id parameter
		}

		#region Saar's
		private void FinishButton_Click(object sender, EventArgs e)
		{
			UpdateCurrQuestion();

			if (!string.IsNullOrWhiteSpace(TitleTextBox.Text))
			{
				if (char.IsLetter(TitleTextBox.Text[0]))
				{

					using (var unit = new UnitOfWork(new DAL.ExamContext()))
					{
						unit.Exams.Add(this.exam);
						unit.Complete();
						CreateXMLFiles();
						//unit.Exams.Add(this.exam);
						unit.Complete();

						for (int i = 0; i < exam.Questions.Count; i++)
						{
							if (exam.Questions[i].QuestionImage != null)
							{
								unit.QImages.Add(new QImage { Id = i, ExamId = exam.Id, QuestionImage = ImageToByteArray(exam.Questions[i].QuestionImage) }); 
							}
						}

						unit.Complete();
					}
					// SAVE TO SQL
					user.Classrooms.ElementAt(selectedClassroom).Exams.Add(exam);
					isFinished = true;
					this.Close();
				}
				else
					MessageBox.Show("Exam title must begin with a letter");
			}
			else
				MessageBox.Show("Please Enter Exam Title");

		}

		#region XML Methods
		public void CreateXMLFiles()
		{
			XmlHandler.CreateGradesFile(exam);
			XmlHandler.CreateQuestionsFile(exam);
		}

		#endregion

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
			exam.Questions[CurrQuestionIndex].QuestionImage = QuestionBuilder.QuestionImage;
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
			QuestionBuilder.QuestionImage = currQuestion.QuestionImage;
		}

		private void LoadClassroomsComboBox()
		{
			//using (var unit = new UnitOfWork(new DAL.ExamContext()))
			//{
			//	List<Classroom> classrooms = unit.Users.GetById(teacherId).Classrooms.ToList();

			//	unit.Complete();
			//}
			List<string> classroomsList = new List<string>();
			foreach (Classroom classroom in user.Classrooms)
			{
				classroomsList.Add(classroom.Name);
			}
			ClassroomsComboBox.DataSource = classroomsList;
			//ClassroomsComboBox.ValueMember = "Id";
			//	ClassroomsComboBox.DisplayMember = "Name";
			//	ClassroomsComboBox.DataSource = user.Classrooms;
		}

		private void TitleTextBox_TextChanged(object sender, EventArgs e)
		{
			exam.Title = TitleTextBox.Text;
		}

		private void ClassroomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedClassroom = ClassroomsComboBox.SelectedIndex;
			exam.ClassroomId = user.Classrooms.ElementAt(selectedClassroom).Id;
		}

		// from https://stackoverflow.com/questions/25400555/save-and-retrieve-image-binary-from-sql-server-using-entity-framework-6
		public byte[] ImageToByteArray(Image imageIn)
		{
			using (var ms = new MemoryStream())
			{
				imageIn.Save(ms, ImageFormat.Gif);

				return ms.ToArray();
			}
		}

		// from https://stackoverflow.com/questions/25400555/save-and-retrieve-image-binary-from-sql-server-using-entity-framework-6
		//public Image ByteArrayToImage(byte[] byteArrayIn)
		//{
		//	using (var ms = new MemoryStream(byteArrayIn))
		//	{
		//		var returnImage = Image.FromStream(ms);

		//		return returnImage;
		//	}
		//}
		#endregion

		public void FormShowDialog()
		{
			this.ShowDialog();
		}
	}
}
