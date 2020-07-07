using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Exam
    {
        public List<IQuestion> Questions { get; set; } = new List<IQuestion>();
        public double FinalGrade { get; set; }
        public Timer ExamTime { get; set; }
        public bool IsTimed { get; set; }
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public string QuestionsPath { get; set; }
        public string Title { get; set; }

        public Exam()
        {

        }

        public Exam(int examId)
        {
            ExamId = examId;
            GetExam(examId);
        }

        private void GetExam(int examId)
        {

        }

        public void GetQuestions()
        {

        }
        

    }
}
