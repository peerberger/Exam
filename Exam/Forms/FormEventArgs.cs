using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Forms
{
    public class FormEventArgs : EventArgs
    {
        public object DataForNextForm { get; set; }

        public FormEventArgs(object data)
        {
            DataForNextForm = data;
        }
    }
}
