using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.UserControls.LoginView
{
    public interface ILoginView
    {
        void SetController(Controllers.LoginController controller);
        string Id { get; set; }
        string Password { get; set; }
        event EventHandler IdTextChanged;
        event EventHandler LoginClicked;
        void CouldNotLogin(string alert);
    }
}
