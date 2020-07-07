﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class OpenQuestion : IGenericQuestion<string>
    {
        public string QuestionDescription { get; set; }
        public string RightAnswer { get; set; }
        public string QuestionText { get; set; }
        public double Points { get; set; }
    }
}
