using Exam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.UserControls.QuestionBuilderView
{
	public interface IQuestionBuilderView
	{
		bool QuestionTypeMultiple { get; set; }
		bool QuestionTypeOpen { get; set; }
		string Description { get; set; }
		string QuestionText { get; set; }
		string RightAnswer { get; set; }
		List<string> Answers { get; }



		void SetController(QuestionBuilderController controller);

	}
}
