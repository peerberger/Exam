using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Exam
{
	public partial class QuestionPage_Student : Form
	{
		public QuestionPage_Student()
		{
			InitializeComponent();
			DAL.Repositories.QuestionsXmlRepository questionsXml = new DAL.Repositories.QuestionsXmlRepository();
			MockData.LoadMocData();
			Library.Models.Exam exam = MockData.exams[0];
			questionsXml.Update(exam);
		}
	}
}
