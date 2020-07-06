using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class MultipleChoiceQuestion : IGenericQuestion<int>
    {
        public int RightAnswer { get; set; }
        public string QuestionText { get; set; }
        public double Points { get; set; }
        public List<string> Answers { get; set; } = new List<string>();

    }
}
