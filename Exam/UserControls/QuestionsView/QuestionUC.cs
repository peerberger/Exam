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
        private string openQuestionAnswer;
        QuestionController _controller;
      //  public bool isAnswered;
        private EventHandler questionAnswered;
        public event EventHandler QuestionAnswered
        {
            add { questionAnswered += value; }
            remove { questionAnswered -= value; }
        }

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
        public string QuestionDescription { get => descriptionTextBox.Text; set => descriptionTextBox.Text = value; }

        public QuestionUC()
        {
            InitializeComponent();

            //CurrQuestion = Class1.LoadQ1();
        }

        #region View Initializers

        public void LoadQuestion(IQuestion question)
        {
            _answers.Clear();
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
            TextBox answerTextBox = new TextBox();
            answerTextBox.TextChanged += AnswerTextBox_TextChanged;
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
        #endregion

        #region Events 

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
      //      isAnswered = true;
            questionAnswered.Invoke(this, null);

        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            openQuestionAnswer = (sender as TextBox).Text;
            questionAnswered.Invoke(this, null);
        }   

        #endregion
        public string GetAnswer()
        {
            foreach (var radio in _answers)
            {
                if (radio != null && radio.Checked)
                {
                    return radio.Name;
                }
            }
            return openQuestionAnswer;
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
