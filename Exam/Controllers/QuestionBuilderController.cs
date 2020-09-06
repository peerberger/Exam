using Exam.UserControls.QuestionBuilderView;
using Library.Models;
using Library.Models.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Controllers
{
	public class QuestionBuilderController
	{
		public IQuestionBuilderView _view;
		public User _user;
		//private Question _question;


        public QuestionBuilderController(User user, IQuestionBuilderView view)
        {
			this._user = user;
			this._view = view;
        }

    }
}
