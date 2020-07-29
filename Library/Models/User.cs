using System;
using System.Collections.Generic;

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
    }
}