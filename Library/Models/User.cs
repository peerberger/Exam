using System;
using System.Collections.Generic;

namespace Library.Models
{
    public enum Users
    {
        Admin =0,
        Teacher = 1,
        Student = 2
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Users Role { get; set; }
        public int ClassroomId { get; set; }
        public List<Exam> Exams { get; set; }
    }
}