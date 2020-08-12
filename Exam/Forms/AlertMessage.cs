using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Forms
{
    public partial class AlertMessage : Form
    {
        public AlertMessage(string alert)
        {
            InitializeComponent();
            this.warningLable.Text = alert;
            //Setting the form to center screen
            //User can't change form size
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

    }
}
