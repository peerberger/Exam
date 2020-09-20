using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;
using Library.Models.Questions;

namespace Library.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ClassroomId { get; set; }
        //public Timer ExamTime { get; set; }
        public bool IsTimed { get; set; }
        public string QuestionsPath { get; set; }
        public List<IQuestion> Questions { get; set; } = new List<IQuestion>();
        [NotMapped]
        public double? FinalGrade { get; set; }
        [NotMapped]
        public bool IsAnswered { get; set; }
        public string GradesPath { get; set; }
        public int? Time { get; set; }


        public Exam()
        {

        }

        public Exam(int examId)
        {
            Id = examId;
            GetExam(examId);
        }

        private void GetExam(int examId)
        {

        }

       
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }




    }
}
