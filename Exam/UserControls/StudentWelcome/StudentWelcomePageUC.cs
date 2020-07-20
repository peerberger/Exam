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

namespace Exam.UserControls
{
    public partial class StudentWelcomePageUC : UserControl, IStudentWelcomePage
    {


        public int SelectedExam { get; set; }
        public object ExamsDataSource
        {
            get => examsGridView.DataSource;
            set
            {
                examsGridView.DataSource = value;
                ResizeDataGrid();
            }
        }

        private StudentWelcomePageController _controller;
        private EventHandler startExam;
        public event EventHandler StartExam
        {
            add
            {
                startExam += value;
            }
            remove
            {
                startExam -= value;
            }
        }

        public StudentWelcomePageUC()
        {
            InitializeComponent();
        }
        #region Events

        public void SetController(StudentWelcomePageController controller)
        {
            _controller = controller;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startExam.Invoke(this, null);
        }

        private void examsGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = examsGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
            {
                return;
            }
            var row = examsGridView.SelectedRows[0];
            if (row == null)
            {
                return;
            }
            int rowIndex = row.Index;
            bool isCompleted = IsExamCompleted(rowIndex);//Checking if the selected exam is completed
            //If comleted disable the start button
            if (isCompleted)
            {
                startButton.Enabled = false;
            }
            else
            {
                startButton.Enabled = true;
                SelectedExam = rowIndex;
            }
        }

        #endregion

        #region Methods

        private bool IsExamCompleted(int index)
        {
            return _controller.user.Exams[index].IsAnswered;
        }

        //Resizinf the DataGridView around the data
        private void ResizeDataGrid()
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            examsGridView.ScrollBars = ScrollBars.None;
            var totalHeight = examsGridView.Rows.GetRowsHeight(states) + examsGridView.ColumnHeadersHeight - 6;
            var totalWidth = examsGridView.Columns.GetColumnsWidth(states) + examsGridView.RowHeadersWidth - 3;
            examsGridView.ClientSize = new Size(totalWidth, totalHeight);
        }

        #endregion
    }
}
