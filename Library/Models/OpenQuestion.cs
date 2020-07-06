using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class OpenQuestion : IGenericQuestion<string>
    {
        public string QuestionDescription { get; set; }
        public string QuestionText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RightAnswer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
