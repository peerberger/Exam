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
using Library.Models;

namespace Exam.Student
{
	public partial class QuestionUC : UserControl, IQuestionView
    {
        //private IQuestion _question;
        private List<RadioButton> _answers = new List<RadioButton>();
        QuestionController _controller;

        //public Library.Models.MultipleChoiceTextQuestion CurrQuestion
        //{
        //    get { return _question; }
        //    set
        //    {
        //        _question = value;
        //        QuestionTextBox.Text = _question.QuestionText;
        //    }
        //}

        public string QuestionText { get => QuestionTextBox.Text; set => QuestionTextBox.Text = value; }
        public string QuestionDescription { get => DescriptionTextBox.Text; set => DescriptionTextBox.Text = value; }

        public QuestionUC()
        {
            InitializeComponent();

            //CurrQuestion = Class1.LoadQ1();
        }
        public void LoadQuestion(IQuestion question)
        {
            if (question is MultipleChoiceQuestion)
            {
                MultipleChoiceQuestion multipleQuestion = question as MultipleChoiceQuestion;
                SetAnswerPartOfView(multipleQuestion.Answers);
            }
            else if (question is OpenQuestion)
            {
                OpenQuestion openQuestion = question as OpenQuestion;
                SetAnswerPartOfView();
            }
        }
        private void SetAnswerPartOfView()
        {
            AnswersFlowLayout.Controls.Clear();
            TextBox answerTextBox = new TextBox() { Margin = new Padding(10)};
            AnswersFlowLayout.Controls.Add(answerTextBox);
        }

        private void SetAnswerPartOfView(List<string> answers)
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

        public string GetAnswer()
        {
            foreach (var radio in _answers)
            {
                if (radio != null && radio.Checked)
                {
                    return radio.Name;
                }
            }
            return null;
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
