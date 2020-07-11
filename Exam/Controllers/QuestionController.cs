using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.Student;
using Library;
using Library.Models;

namespace Exam.Controllers
{
    public class QuestionController
    {
        private IQuestionView _view;
        private IQuestion _question;

        public QuestionController(IQuestionView view, IQuestion question, QuestionPage_Student form)
        {
            _question = question;
            _view = view;
            _view.SetController(this);
            LoadQuestionToView();
            form.NextClicked += Form_NextClicked;
        }

        public void SetQuestion(IQuestion question)
        {
            _question = question;
        }
        private void Form_NextClicked(object sender, EventArgs e)
        {
            QuestionPage_Student form = sender as QuestionPage_Student;
            _question = form._exam.Questions[form.questionNumber];
            LoadQuestionToView();
        }

        private void LoadQuestionToView()
        {
            _view.QuestionDescription = _question.QuestionDescription;
            _view.QuestionText = _question.QuestionText;
            if(_question is MultipleChoiceQuestion)
            {
                MultipleChoiceQuestion multipleQuestion = _question as MultipleChoiceQuestion;
                _view.SetAnswerPartOfView(multipleQuestion.Answers);
            }
            else if (_question is OpenQuestion)
            {
                OpenQuestion openQuestion = _question as OpenQuestion;
                _view.SetAnswerPartOfView();
            }
        }
    }
}
