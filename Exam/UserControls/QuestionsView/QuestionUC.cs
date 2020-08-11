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
        private Random rng = new Random();
        private List<RadioButton> _answers = new List<RadioButton>();
        private string openQuestionAnswer;
        QuestionController _controller;
        private EventHandler questionAnswered;
        public event EventHandler QuestionAnswered
        {
            add { questionAnswered += value; }
            remove { questionAnswered -= value; }
        }

        public string QuestionText { get => QuestionTextBox.Text; set => QuestionTextBox.Text = value; }
        public string QuestionDescription { get => DescriptionTextBox.Text; set => DescriptionTextBox.Text = value; }

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
            TextBox answerTextBox = new TextBox() { Margin = new Padding(10) };
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
            ShuffleList(answers);
            foreach (string answer in answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

                radioButton.Margin = new Padding(10);
                radioButton.Text = answer;

                _answers.Add(radioButton);

                this.AnswersFlowLayout.Controls.Add(radioButton);

            }
        }
        #endregion

        #region Events 
        private void ShuffleList<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }    
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            questionAnswered.Invoke(this, null);

        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            openQuestionAnswer = (sender as TextBox).Text;
            questionAnswered.Invoke(this, null);
        }

        #endregion

        #region Methods

        public string GetAnswer()
        {
            foreach (var radio in _answers)
            {
                if (radio != null && radio.Checked)
                {
                    return radio.Text;
                }
            }
            //if there are no radio buttons -> this is an open question
            return openQuestionAnswer;
        }

        public void SetController(QuestionController controller)
        {
            this._controller = controller;
        }

        #endregion
    }
}
