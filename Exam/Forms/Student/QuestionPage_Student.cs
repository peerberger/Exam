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
using Exam.Forms;
using Exam.Student;
using Exam.UserControls;
using Library;
using Library.Models;

namespace Exam
{

    public partial class QuestionPage_Student : Form, IAppsForms
    {
        public Library.Models.Exam _exam;
        public int questionNumber;
        private QuestionController questionController;
        private TimerController timerController;
        private TimeBarUC timeBarView;
        private EventHandler<FormEventArgs> changeForm;
        public event EventHandler<FormEventArgs> ChangeForm
        {
            add
            {
                if (changeForm == null)
                {

                    changeForm += value;
                }
            }
            remove { changeForm -= value; }
        }

        public QuestionPage_Student(Library.Models.Exam exam)
        {
            InitializeComponent();
            _exam = exam;
            _exam.LoadQuestions();
            questionNumber = 0;
            this.UpdateQuestionNumberLabel();
            if (_exam.Questions.Count != 0 && _exam.Questions != null)
            {
                CreatQuestionController();
                if (_exam.IsTimed)
                {
                    CreateTimeBar();
                }
            }

        }

        #region Methods    
        private void CreateTimeBar()
        {
            timeBarView = new TimeBarUC();
            this.TableLayout.Controls.Add(timeBarView, 0, 0);
            this.TableLayout.SetColumnSpan(timeBarView, 3);
            timeBarView.Dock = System.Windows.Forms.DockStyle.Fill;
            timeBarView.Location = new System.Drawing.Point(3, 3);
            timeBarView.Name = "timeBar";
            timeBarView.Size = new System.Drawing.Size(794, 39);
            timeBarView.TabIndex = 7;
            CreateTimerController();
        }

        private void CreateTimerController()
        {
            timerController = new TimerController(5, timeBarView); // NEEDS CHANGING TO EXAM TIME
            timerController.TimeOver += TimerController_TimeOver;
        }

        private void TimerController_TimeOver(object sender, EventArgs e)
        {
            //Time Over - End Test
            MessageBox.Show("Exam time ran out!\r\nPlease click OK to continue.","Time Over");
            GradeExam();
        }

        private void CreatQuestionController()
        {
            questionController =
                      new QuestionController(this.Question, _exam.Questions[questionNumber]);
            questionController.QuestionAnswered += QuestionController_QuestionAnswered;
        }
        private void UpdateQuestionNumberLabel()
        {
            this.QuestionNumberLabel.Text = $"{questionNumber + 1} / {_exam.Questions.Count}";
        }
        private void InitializeFinishUC()
        {
            var finishMessage = new FinishMessageUC();
            this.TableLayout.Controls.Add(finishMessage, 0, 1);

            this.TableLayout.SetColumnSpan(finishMessage, 3);
            finishMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            finishMessage.Location = new System.Drawing.Point(3, 48);
            finishMessage.Name = "finishMessage";
            finishMessage.ButtonClicked += FinishMessage_ButtonClicked;
        }


        private void GradeExam()
        {
            _exam.FinalGrade = 0;
            foreach (var question in _exam.Questions)
            {
                if (question.IsCorrect)
                {
                    _exam.FinalGrade += question.Points;
                }
            }
            GradePage_Student gradeForm = new GradePage_Student(_exam.FinalGrade.ToString());
            gradeForm.ShowDialog();
            _exam.IsAnswered = true;
            this.Close();
        }
        #endregion

        #region Events

        private void QuestionController_QuestionAnswered(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
        }



        private void NextButton_Click(object sender, EventArgs e)
        {
            NextButton.Enabled = false;
            PreviousButton.Enabled = true;
            questionController.UpdateIsRightAnswer();
            questionNumber++;
            if (questionNumber < _exam.Questions.Count)
            {
                this.UpdateQuestionNumberLabel();
                questionController.UpdateQuestionView(_exam.Questions[questionNumber]);
                if (questionNumber == _exam.Questions.Count - 1)
                {
                    this.NextButton.Text = "Finish";
                }
            }
            else
            {
                this.TableLayout.Controls.Remove(Question);
                this.Question.Dispose();
                InitializeFinishUC();

            }
        }
        private void FinishMessage_ButtonClicked(object sender, EventArgs e)
        {
            GradeExam();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {

            questionNumber--;
            this.UpdateQuestionNumberLabel();
            questionController.UpdateQuestionView(_exam.Questions[questionNumber]);
            if (questionNumber == 0)
            {
                PreviousButton.Enabled = false;
            }
            //else
            //{
            //    //MessageBox.Show("This is the start");
            //}
        }


        //Preventing from form to close
        private void QuestionPage_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formSender = sender as QuestionPage_Student;
             if(!  formSender._exam.IsAnswered)
            {
            MessageBox.Show("You can't quit a test \r\nonce you've started", "Test In Progress");
            e.Cancel = true;
            }
        }

        #endregion
        public void FormShowDialog()
        {
            this.ShowDialog();
        }
    }
}
