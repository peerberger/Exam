﻿using System;
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
        public event EventHandler QuestionAnswered;

        public QuestionController(IQuestionView view, IQuestion question)
        {
            _question = question;
            _view = view;
            _view.SetController(this);
            _view.QuestionAnswered += _view_QuestionAnswered;
            LoadQuestionToView();
        }

        private void _view_QuestionAnswered(object sender, EventArgs e)
        {
            QuestionAnswered.Invoke(this, null);
        }

        public void UpdateQuestionView(IQuestion question)
        {
            SetQuestion(question);
            LoadQuestionToView();
        }
        public void SetQuestion(IQuestion question)
        {
            _question = question;
        }
        //private void Form_NextClicked(object sender, EventArgs e)
        //{
        //    QuestionPage_Student form = sender as QuestionPage_Student;
        //    _question = form._exam.Questions[form.questionNumber];
        //    LoadQuestionToView();
        //}

        private void LoadQuestionToView()
        {
            _view.QuestionDescription = _question.QuestionDescription;
            _view.QuestionText = _question.QuestionText;
            _view.LoadQuestion(_question);
        }
        public void UpdateIsRightAnswer()
        {
            string userAnswer = _view.GetAnswer();
            if (userAnswer != null)
            {
                _question.IsAnswered = true;
                if (userAnswer == _question.RightAnswer)
                {
                    _question.IsCorrect = true;
                }
            }
        }

        public void ShowImage(IQuestion question)
        {
            _view.LoadImage(question.QuestionImage);
        }
    }
}
