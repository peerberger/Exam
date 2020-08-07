namespace Exam.Forms.Student
{
	partial class QuestionPage_Teacher
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.ClassroomsComboBox = new System.Windows.Forms.ComboBox();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.TimeLimitLabel = new System.Windows.Forms.Label();
			this.ClassroomLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.NextButton = new System.Windows.Forms.Button();
			this.QuestionNumberLabel = new System.Windows.Forms.Label();
			this.FinishButton = new System.Windows.Forms.Button();
			this.PreviousButton = new System.Windows.Forms.Button();
			this.OpenImageFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.QuestionBuilder = new Exam.UserControls.QuestionBuilderUC();
			this.TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 4;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.Controls.Add(this.ClassroomsComboBox, 2, 3);
			this.TableLayout.Controls.Add(this.TitleTextBox, 2, 1);
			this.TableLayout.Controls.Add(this.TimeLimitLabel, 2, 4);
			this.TableLayout.Controls.Add(this.ClassroomLabel, 2, 2);
			this.TableLayout.Controls.Add(this.TitleLabel, 2, 0);
			this.TableLayout.Controls.Add(this.NextButton, 2, 6);
			this.TableLayout.Controls.Add(this.QuestionNumberLabel, 1, 6);
			this.TableLayout.Controls.Add(this.FinishButton, 3, 6);
			this.TableLayout.Controls.Add(this.PreviousButton, 0, 6);
			this.TableLayout.Controls.Add(this.QuestionBuilder, 0, 0);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 7;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayout.Size = new System.Drawing.Size(800, 450);
			this.TableLayout.TabIndex = 1;
			// 
			// ClassroomsComboBox
			// 
			this.ClassroomsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ClassroomsComboBox.FormattingEnabled = true;
			this.ClassroomsComboBox.Location = new System.Drawing.Point(690, 211);
			this.ClassroomsComboBox.Margin = new System.Windows.Forms.Padding(10);
			this.ClassroomsComboBox.Name = "ClassroomsComboBox";
			this.ClassroomsComboBox.Size = new System.Drawing.Size(100, 21);
			this.ClassroomsComboBox.TabIndex = 19;
			this.ClassroomsComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassroomsComboBox_SelectedIndexChanged);
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TitleTextBox.Location = new System.Drawing.Point(690, 77);
			this.TitleTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
			this.TitleTextBox.TabIndex = 18;
			this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
			// 
			// TimeLimitLabel
			// 
			this.TimeLimitLabel.AutoSize = true;
			this.TimeLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TimeLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.TimeLimitLabel.Location = new System.Drawing.Point(690, 278);
			this.TimeLimitLabel.Margin = new System.Windows.Forms.Padding(10);
			this.TimeLimitLabel.Name = "TimeLimitLabel";
			this.TimeLimitLabel.Size = new System.Drawing.Size(100, 47);
			this.TimeLimitLabel.TabIndex = 17;
			this.TimeLimitLabel.Text = "Time limit:";
			this.TimeLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ClassroomLabel
			// 
			this.ClassroomLabel.AutoSize = true;
			this.ClassroomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ClassroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.ClassroomLabel.Location = new System.Drawing.Point(690, 144);
			this.ClassroomLabel.Margin = new System.Windows.Forms.Padding(10);
			this.ClassroomLabel.Name = "ClassroomLabel";
			this.ClassroomLabel.Size = new System.Drawing.Size(100, 47);
			this.ClassroomLabel.TabIndex = 16;
			this.ClassroomLabel.Text = "Classroom:";
			this.ClassroomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.TitleLabel.Location = new System.Drawing.Point(690, 10);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(10);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(100, 47);
			this.TitleLabel.TabIndex = 15;
			this.TitleLabel.Text = "Title:";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NextButton
			// 
			this.NextButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NextButton.Location = new System.Drawing.Point(570, 390);
			this.NextButton.Margin = new System.Windows.Forms.Padding(10);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(100, 50);
			this.NextButton.TabIndex = 13;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// QuestionNumberLabel
			// 
			this.QuestionNumberLabel.AutoSize = true;
			this.QuestionNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionNumberLabel.Location = new System.Drawing.Point(130, 390);
			this.QuestionNumberLabel.Margin = new System.Windows.Forms.Padding(10);
			this.QuestionNumberLabel.Name = "QuestionNumberLabel";
			this.QuestionNumberLabel.Size = new System.Drawing.Size(420, 50);
			this.QuestionNumberLabel.TabIndex = 10;
			this.QuestionNumberLabel.Text = "1 / 1";
			this.QuestionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FinishButton
			// 
			this.FinishButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FinishButton.Location = new System.Drawing.Point(690, 390);
			this.FinishButton.Margin = new System.Windows.Forms.Padding(10);
			this.FinishButton.Name = "FinishButton";
			this.FinishButton.Size = new System.Drawing.Size(100, 50);
			this.FinishButton.TabIndex = 5;
			this.FinishButton.Text = "Finish";
			this.FinishButton.UseVisualStyleBackColor = true;
			this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
			// 
			// PreviousButton
			// 
			this.PreviousButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PreviousButton.Enabled = false;
			this.PreviousButton.Location = new System.Drawing.Point(10, 390);
			this.PreviousButton.Margin = new System.Windows.Forms.Padding(10);
			this.PreviousButton.Name = "PreviousButton";
			this.PreviousButton.Size = new System.Drawing.Size(100, 50);
			this.PreviousButton.TabIndex = 4;
			this.PreviousButton.Text = "Previous";
			this.PreviousButton.UseVisualStyleBackColor = true;
			this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
			// 
			// OpenImageFileDialog
			// 
			this.OpenImageFileDialog.FileName = "openFileDialog1";
			// 
			// QuestionBuilder
			// 
			this.TableLayout.SetColumnSpan(this.QuestionBuilder, 3);
			this.QuestionBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionBuilder.Location = new System.Drawing.Point(3, 3);
			this.QuestionBuilder.Name = "QuestionBuilder";
			this.TableLayout.SetRowSpan(this.QuestionBuilder, 6);
			this.QuestionBuilder.Size = new System.Drawing.Size(674, 374);
			this.QuestionBuilder.TabIndex = 14;
			// 
			// QuestionPage_Teacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TableLayout);
			this.Name = "QuestionPage_Teacher";
			this.Text = "QuestionPage_Teacher";
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Button FinishButton;
		private System.Windows.Forms.Button PreviousButton;
		private System.Windows.Forms.Label QuestionNumberLabel;
		private System.Windows.Forms.OpenFileDialog OpenImageFileDialog;
		private System.Windows.Forms.Button NextButton;
		private UserControls.QuestionBuilderUC QuestionBuilder;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label ClassroomLabel;
		private System.Windows.Forms.Label TimeLimitLabel;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.ComboBox ClassroomsComboBox;
	}
}