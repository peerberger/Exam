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
	public partial class FinishMessageUC : UserControl
	{
		public event EventHandler ButtonClicked;
		public FinishMessageUC()
		{
			InitializeComponent();
		}

        private void FinishButton_Click(object sender, EventArgs e)
        {
			ButtonClicked.Invoke(this, null);
        }
    }
}
