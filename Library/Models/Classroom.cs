﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Exam> Exams { get; set; }
        public List<User> Students { get; set; }
    }
}
