using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Questions
{
	public class MultipleChoiceQuestion : Question // IQuestion
	{
		//public string RightAnswer { get; set; }
		//public string QuestionText { get; set; }
		//public double Points { get; set; }
		//public string QuestionDescription { get; set; }
		//public bool IsAnswered { get; set; }
		//public bool IsCorrect { get; set; }
		public List<string> Answers { get; set; } = new List<string>();

		public MultipleChoiceQuestion()
		{
			QuestionDescription = "Select the correct answer";
		}


	}
}
