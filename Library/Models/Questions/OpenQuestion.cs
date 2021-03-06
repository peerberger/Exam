﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Questions
{
	public class OpenQuestion : IQuestion
	{
		public string QuestionDescription { get; set; }
		public string RightAnswer { get; set; }
		public string QuestionText { get; set; }
		public double Points { get; set; }
		public bool IsAnswered { get; set; }
		public bool IsCorrect { get; set; }
		public Image QuestionImage { get; set; }

	}
}
