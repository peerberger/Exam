using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.Controllers;

namespace Exam.UserControls.LoginView
{
    public partial class LoginUC : UserControl, ILoginView
    {
        private LoginController _controller;
        public string Id
        {
            get => idTextBox.Text;
            set => idTextBox.Text = value;
        }
        public string Password
        {
            get => passwordTextBox.Text;
            set { passwordTextBox.Text = value; }
        }

        private EventHandler idTextChanged;
        private EventHandler loginClicked;

        public event EventHandler IdTextChanged
        {
            add
            {
                idTextChanged += value;
            }

            remove
            {
                idTextChanged -= value;
            }
        }
        public event EventHandler LoginClicked
        {
            add
            {
                loginClicked += value;
            }

            remove
            {
                loginClicked -= value;
            }
        }

        public LoginUC()
        {
            InitializeComponent();
        }
        public void SetController(LoginController controller)
        {
            this._controller = controller;
        }

        public void CouldNotLogin(string alert)
        {
            MessageBox.Show(alert, "Could Not Login");
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            idTextChanged.Invoke(this, null);// Raising event for the controller
            idTextBox.SelectionStart = idTextBox.Text.Length;//Setting the cursor at the end of the line
            idTextBox.SelectionLength = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginClicked.Invoke(this, null);// Raising event for the controller
        }
    }
}
