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
	public partial class WelcomeStudentViewUC : WelcomeView, IStudentWelcomePage
	{
        private bool firstInitialize;
        public int SelectedExam { get; set; }
        public object ExamsDataSource
        {
            get => GradesGridView.DataSource;
            set
            {
                GradesGridView.DataSource = value;
                if (value != null)
                {
                    ResizeDataGrid();
                }
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

        public WelcomeStudentViewUC()
        {
            InitializeComponent();
            firstInitialize = true;
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
            var rowsCount = GradesGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
            {
                return;
            }
            var row = GradesGridView.SelectedRows[0];
            if (row == null)
            {
                return;
            }
            int rowIndex = row.Index;
            bool isCompleted = IsExamCompleted(rowIndex);//Checking if the selected exam is completed
            //If comleted disable the start button
            if (isCompleted)
            {
                StartButton.Enabled = false;
            }
            else
            {
                StartButton.Enabled = true;
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
            GradesGridView.ScrollBars = ScrollBars.None;

            var totalHeight = GradesGridView.Rows.GetRowsHeight(states) + GradesGridView.ColumnHeadersHeight;
            var totalWidth = GradesGridView.Columns.GetColumnsWidth(states) + GradesGridView.RowHeadersWidth;
            if (firstInitialize)
            {
                totalHeight -= 8;
                totalWidth -= 5;
                firstInitialize = false;
            }
            GradesGridView.ClientSize = new Size(totalWidth, totalHeight);
        }

        #endregion
    }
}
