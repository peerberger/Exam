using Exam.Controllers;
using System.Collections.Generic;
using Library.Models;

namespace Exam.Student
{
	public interface IQuestionView
	{
		void SetController(QuestionController controller);
		string QuestionText { get; set; }
		string QuestionDescription { get; set; }
		//void SetAnswerPartOfView();
		//void SetAnswerPartOfView(List<string> answers);
		string GetAnswer();
		void LoadQuestion(IQuestion question);
		//	void LoadQuestion();
	}
}