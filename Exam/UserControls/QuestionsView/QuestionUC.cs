using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.UserControls;
using Exam.Controllers;

namespace Exam.Student
{
	public partial class QuestionUC : UserControl, IQuestionView
	{
        private Library.Models.MultipleChoiceTextQuestion _question;
        private List<RadioButton> _answers = new List<RadioButton>();
        QuestionController _controller;
     
        public Library.Models.MultipleChoiceTextQuestion CurrQuestion
        {
            get { return _question; }
    set
            {
                _question = value;
                QuestionTextBox.Text = _question.QuestionText;
            }
}

public string QuestionText { get => QuestionTextBox.Text; set => QuestionTextBox.Text = value; }
        public string QuestionDescription { get => descriptionTextBox.Text; set => descriptionTextBox.Text = value; }

        public QuestionUC()
		{
			InitializeComponent();

            //CurrQuestion = Class1.LoadQ1();
		}
        public void SetAnswerPartOfView()
        {
            AnswersFlowLayout.Controls.Clear();
            TextBox answerTextBox = new TextBox();
            AnswersFlowLayout.Controls.Add(answerTextBox);
        }

        public void SetAnswerPartOfView(List<string> answers)
        {
            this.AddAnswersToView(answers);
        }

        private void AddAnswersToView(List<string> answers)
        {
            // removing the existing answers
            AnswersFlowLayout.Controls.Clear();

            // inserting the current answers
            int answerId = 0;
            foreach (string answer in answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

                radioButton.Margin = new Padding(10);
                radioButton.Text = answer;
                radioButton.Name = answerId.ToString();

                this.AnswersFlowLayout.Controls.Add(radioButton);
                answerId++;
                _answers.Add(radioButton);
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
        }

        private RadioButton GetCheckedRadio()
        {
            foreach (var radio in _answers)
            {
                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }
            return null;
        }

        public bool IsRightAnswer()
        {
            var checkedButton = GetCheckedRadio();
            if (int.Parse(checkedButton.Name) == CurrQuestion.RightAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetController(QuestionController controller)
        {
            this._controller = controller;
        }


        //public void LoadQuestion()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
