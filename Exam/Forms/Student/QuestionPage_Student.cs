using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.Controllers;
using Exam.Student;
using Library;
using Library.Models;

namespace Exam
{
	public partial class QuestionPage_Student : Form
	{
        public Library.Models.Exam _exam;
        public int questionNumber;
        private QuestionController questionController;
        //private EventHandler nextClicked;
        //public event EventHandler NextClicked
        //{
        //    add
        //    {
        //        nextClicked += value;
        //    }

        //    remove
        //    {
        //        nextClicked -= value;
        //    }
        //}
        public QuestionPage_Student(Library.Models.Exam exam)
		{
			InitializeComponent();

            //Library.Repositories.QuestionsXmlRepository questionsXml = new Library.Repositories.QuestionsXmlRepository();
            _exam = exam;
			questionNumber = 0;
            this.UpdateQuestionNumberLabel();
            if (_exam.Questions.Count!=0 && _exam.Questions!= null)
            {
                CreatQuestionController();
            }

        }
        private void CreatQuestionController()
        {
            questionController =
                      new QuestionController(this.Question, _exam.Questions[questionNumber]);
            questionController.QuestionAnswered += QuestionController_QuestionAnswered;
        }

        private void QuestionController_QuestionAnswered(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
        }

        //private Library.Models.Exam LoadExam()
        //{
        //   //Getting the selected exam
        //    MockData.LoadMocData();
        //    return MockData.exams[0];
        //}

        private void NextButton_Click(object sender, EventArgs e)
        {
            questionController.UpdateIsRightAnswer();
            questionNumber++;
            this.UpdateQuestionNumberLabel();
            if (questionNumber < _exam.Questions.Count)
            {
                questionController.UpdateQuestionView(_exam.Questions[questionNumber]);
                if(questionNumber == _exam.Questions.Count-1)
                {
                    this.NextButton.Text = "Finish";
                }
                NextButton.Enabled = false;
            }
            else
            {
                foreach (var question in _exam.Questions)
                {
                    if (question.IsCorrect)
                    {
                        _exam.FinalGrade += question.Points;
                    }
                }
                MessageBox.Show(_exam.FinalGrade.ToString());
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {

            questionNumber--;
            this.UpdateQuestionNumberLabel();
            if (questionNumber >= 0)
            {
                questionController.UpdateQuestionView(_exam.Questions[questionNumber]);
            }
            else
            {
                MessageBox.Show("This is the start");
            }
        }
        private void UpdateQuestionNumberLabel()
        {
            this.questionNumberLabel.Text = $"{questionNumber + 1} / {_exam.Questions.Count}";
        }
    }
}
