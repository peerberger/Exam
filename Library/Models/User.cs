using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Library.Models
{
    public enum Users
    {
        Admin = 0,
        Teacher = 1,
        Student = 2
    }
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Users Role { get; set; }
        public List<Exam> Exams { get; set; } = new List<Exam>();
        // for 'many to many' joining table
        public virtual ICollection<Classroom> Classrooms { get; set; }

        public void AddToExams(Exam exam)
        {
            Exams.Add(exam);
            if (this.Role == Users.Student)
            {
                UpdateExamStatus(exam);
            }
        }

        private void UpdateExamStatus(Exam exam)
        {
            LoadDemoXML(exam);
            var examXMLStr = File.ReadAllText(exam.GradesPath);
            var examXML = XElement.Parse(examXMLStr);
            var studentElement = examXML.Elements("Student").
                Where(x => x.Element("ID").Value.Equals(Id)).ToList();
            if (studentElement.Count != 0)
            {
                exam.FinalGrade = double.Parse(studentElement[0].Element("Grade").Value);
                exam.IsAnswered = true;
            }
            else
            {
                exam.LoadQuestions();
            }
        }

        

        private void LoadDemoXML(Exam exam)
        {
            exam.GradesPath = @"C:\Users\Saar\Documents\GitHub\Exam\Exam\bin\Debug\ExamsGrades\TestExam_10.xml";
            exam.QuestionsPath = @"C:\Users\Saar\Documents\Exam - copy\Exam\bin\Debug\ExamsQuestions\SimpleMathTest_0.xml";
        }

        public void UpdateExamGradeXML(Exam exam)
        { 
            string filePath = exam.GradesPath;
        //    if (!File.Exists(filePath))
       //    {
         //       Add(entityToUpdate);
         //   }
         //   else
         //   {
                XDocument xmlDoc = XDocument.Load(filePath);
                XElement xStudent = new XElement("Student");
                xStudent.Add(new XElement("ID", this.Id));
                xStudent.Add(new XElement("Grade", exam.FinalGrade));
                xmlDoc.Element(xmlDoc.Root.Name.LocalName).Add(xStudent);
                xmlDoc.Save(filePath);
       //     }
        }
    }
}