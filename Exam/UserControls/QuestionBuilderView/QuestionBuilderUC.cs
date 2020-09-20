using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.UserControls.QuestionBuilderView;
using Exam.Controllers;

namespace Exam.UserControls
{
	public partial class QuestionBuilderUC : UserControl, IQuestionBuilderView
	{
		public bool QuestionTypeMultiple 
		{ get => MultipleOptionsRadioButton.Checked; set => MultipleOptionsRadioButton.Checked = value; }
		public bool QuestionTypeOpen
		{ get => OpenTextRadioButton.Checked; set => OpenTextRadioButton.Checked = value; }
		public string Description 
		{ get => DescriptionComboBox.SelectedItem.ToString(); set => DescriptionComboBox.Text = value; }
		public string QuestionText 
		{ get => QuestionTextBox.Text; set => QuestionTextBox.Text = value; }
		public string RightAnswer 
		{ get => RightAnswerTextBox.Text; set => RightAnswerTextBox.Text = value; }
		public List<string> Answers
		{
			get
			{
				List<string> answers = new List<string>();

				foreach (var answer in AnswersFlowLayout.Controls)
				{
					answers.Add((answer as AnswerOptionUC).AnswerText);
				}

				return answers;
			}
		}
		public Image QuestionImage
		{ get => QuestionPictureBox.Image; set => QuestionPictureBox.Image = value; }



		public QuestionBuilderUC()
		{
			InitializeComponent();

			List<string> descriptions = new List<string>
			{
				"Choose the right answer!",
				"Fill in the blank!"
			};

			DescriptionComboBox.DataSource = descriptions;
		}


		#region Methods
		public void Reset()
		{
			DescriptionComboBox.SelectedIndex = 0;
			QuestionTextBox.Text = string.Empty;
			RightAnswerTextBox.Text = string.Empty;
			AnswerTextBox.Text = string.Empty;
			MultipleOptionsRadioButton.Checked = true;
			AnswersFlowLayout.Controls.Clear();
			QuestionPictureBox.Image = null;
		}

		public void PopulateAnswers(List<string> answers)
		{
			foreach (var answer in answers)
			{
				AnswerOptionUC answerOption = new AnswerOptionUC { AnswerText = answer, Margin = new Padding(10) };
				AnswersFlowLayout.Controls.Add(answerOption);
			}
		}
		#endregion


		#region Events
		private void AddOptionButton_Click(object sender, EventArgs e)
		{
			AnswerOptionUC answerOption = new AnswerOptionUC { AnswerText = AnswerTextBox.Text, Margin = new Padding(10) };

			AnswersFlowLayout.Controls.Add(answerOption);

			AnswerTextBox.Text = string.Empty;
		}

		private void MultipleOptionsRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (MultipleOptionsRadioButton.Checked)
			{
				AnswersFlowLayout.Visible = true;
				AnswerTextBox.Visible = true;
				AddOptionButton.Visible = true;
			}
		}

		private void OpenTextRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (OpenTextRadioButton.Checked)
			{
				AnswersFlowLayout.Visible = false;
				AnswerTextBox.Visible = false;
				AddOptionButton.Visible = false;
			}
		}

		public void SetController(QuestionBuilderController controller)
		{
			throw new NotImplementedException();
		}

		private void AddImageButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				QuestionPictureBox.Image = new Bitmap(fileDialog.FileName);
			}
		}
		#endregion
	}
}
