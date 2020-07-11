using Exam.Controllers;
using System.Collections.Generic;

namespace Exam.Student
{
	public interface IQuestionView
	{
		void SetController(QuestionController controller);
		string QuestionText { get; set; }
		string QuestionDescription { get; set; }
		void SetAnswerPartOfView();
		void SetAnswerPartOfView(List<string> answers);

		//	void LoadQuestion();
	}
}