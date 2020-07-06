using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Classroom
    {
        public string ClassName { get; set; }
        public List<Exam> Exams { get; set; }
        public List<User> Students { get; set; }
        public int Id { get; set; }
    }
}
