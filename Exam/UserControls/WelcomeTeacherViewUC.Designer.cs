namespace Exam.UserControls
{
	partial class WelcomeTeacherViewUC
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GradesGridView = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildTestButton = new System.Windows.Forms.Button();
            this.TestsComboBox = new System.Windows.Forms.ComboBox();
            this.TableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 5;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TableLayout.Controls.Add(this.GradesGridView, 1, 2);
            this.TableLayout.Controls.Add(this.BuildTestButton, 3, 3);
            this.TableLayout.Controls.Add(this.TestsComboBox, 1, 1);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 6;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayout.Size = new System.Drawing.Size(611, 330);
            this.TableLayout.TabIndex = 6;
            // 
            // GradesGridView
            // 
            this.GradesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Grade});
            this.GradesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradesGridView.Location = new System.Drawing.Point(83, 92);
            this.GradesGridView.Margin = new System.Windows.Forms.Padding(10);
            this.GradesGridView.Name = "GradesGridView";
            this.TableLayout.SetRowSpan(this.GradesGridView, 3);
            this.GradesGridView.Size = new System.Drawing.Size(236, 178);
            this.GradesGridView.TabIndex = 4;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // Grade
            // 
            this.Grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // BuildTestButton
            // 
            this.BuildTestButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.BuildTestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BuildTestButton.Location = new System.Drawing.Point(369, 125);
            this.BuildTestButton.Margin = new System.Windows.Forms.Padding(10);
            this.BuildTestButton.Name = "BuildTestButton";
            this.BuildTestButton.Size = new System.Drawing.Size(157, 79);
            this.BuildTestButton.TabIndex = 3;
            this.BuildTestButton.Text = "Build a Test";
            this.BuildTestButton.UseVisualStyleBackColor = true;
            // 
            // TestsComboBox
            // 
            this.TestsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestsComboBox.FormattingEnabled = true;
            this.TestsComboBox.Location = new System.Drawing.Point(83, 59);
            this.TestsComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.TestsComboBox.Name = "TestsComboBox";
            this.TestsComboBox.Size = new System.Drawing.Size(236, 21);
            this.TestsComboBox.TabIndex = 5;
            this.TestsComboBox.Text = "Tests";
            // 
            // WelcomeTeacherViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayout);
            this.Name = "WelcomeTeacherViewUC";
            this.Size = new System.Drawing.Size(611, 330);
            this.TableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.DataGridView GradesGridView;
		private System.Windows.Forms.Button BuildTestButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn Student;
		private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
		private System.Windows.Forms.ComboBox TestsComboBox;
	}
}
