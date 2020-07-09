using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public interface IQuestion
    {
        string QuestionText { get; set; }
        double Points { get; set; }
    }
}
