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
        public Users Role { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public List<Exam> Exams { get; set; }
    }
}