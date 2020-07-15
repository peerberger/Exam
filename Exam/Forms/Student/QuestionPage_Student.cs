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
        public QuestionPage_Student()
		{
			InitializeComponent();

            //Library.Repositories.QuestionsXmlRepository questionsXml = new Library.Repositories.QuestionsXmlRepository();
            _exam = LoadExam();
			questionNumber = 0;
            if(_exam.Questions.Count!=0 && _exam.Questions!= null)
            {
                CreatQuestionController();
            }

        }

        private Library.Models.Exam LoadExam()
        {
            MockData.LoadMocData();
            return MockData.exams[0];
        }
        private void CreatQuestionController()
        {

            questionController =
                      new QuestionController(this.Question, _exam.Questions[questionNumber]);
        }
        //private void SetQuestionController()
        //{
        //    questionController.SetQuestion(_exam.Questions[questionNumber]);
        //}
        private void NextButton_Click(object sender, EventArgs e)
        {
            questionController.UpdateIsRightAnswer();
            questionNumber++;
            if (questionNumber < _exam.Questions.Count)
            {
                questionController.UpdateQuestionView(_exam.Questions[questionNumber]);
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
            if (questionNumber >= 0)
            {
                questionController.UpdateQuestionView(_exam.Questions[questionNumber]);
            }
            else
            {
                MessageBox.Show("This is the start");
            }
        }
    }
}
