using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.UserControls
{
	public partial class AnswerOptionUC : UserControl
	{
		public string AnswerText { get => AnswerTextBox.Text; set => AnswerTextBox.Text = value; }

		public AnswerOptionUC()
		{
			InitializeComponent();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			this.Parent.Controls.Remove(this);
			this.Dispose();
		}
	}


}