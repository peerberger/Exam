﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Student
{
	public partial class GradePage_Student : Form
	{
		public GradePage_Student()
		{
			InitializeComponent();
		}

        public GradePage_Student(string grade)
        {
			InitializeComponent();
			GradeLabel.Text = grade;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
			this.Close();
        }	
    }
}
