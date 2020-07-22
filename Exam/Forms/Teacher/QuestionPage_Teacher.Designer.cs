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
			this.NextButton = new System.Windows.Forms.Button();
			this.QuestionNumberLabel = new System.Windows.Forms.Label();
			this.FinishButton = new System.Windows.Forms.Button();
			this.PreviousButton = new System.Windows.Forms.Button();
			this.OpenImageFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.BuildQuestion = new Exam.UserControls.QuestionBuilderUC();
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
			this.TableLayout.Controls.Add(this.NextButton, 2, 3);
			this.TableLayout.Controls.Add(this.QuestionNumberLabel, 1, 3);
			this.TableLayout.Controls.Add(this.FinishButton, 3, 3);
			this.TableLayout.Controls.Add(this.PreviousButton, 0, 3);
			this.TableLayout.Controls.Add(this.BuildQuestion, 0, 0);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 4;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayout.Size = new System.Drawing.Size(800, 450);
			this.TableLayout.TabIndex = 1;
			// 
			// NextButton
			// 
			this.NextButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NextButton.Location = new System.Drawing.Point(570, 392);
			this.NextButton.Margin = new System.Windows.Forms.Padding(10);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(100, 48);
			this.NextButton.TabIndex = 13;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			// 
			// QuestionNumberLabel
			// 
			this.QuestionNumberLabel.AutoSize = true;
			this.QuestionNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionNumberLabel.Location = new System.Drawing.Point(130, 392);
			this.QuestionNumberLabel.Margin = new System.Windows.Forms.Padding(10);
			this.QuestionNumberLabel.Name = "QuestionNumberLabel";
			this.QuestionNumberLabel.Size = new System.Drawing.Size(420, 48);
			this.QuestionNumberLabel.TabIndex = 10;
			this.QuestionNumberLabel.Text = "5 / 6";
			this.QuestionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FinishButton
			// 
			this.FinishButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FinishButton.Location = new System.Drawing.Point(690, 392);
			this.FinishButton.Margin = new System.Windows.Forms.Padding(10);
			this.FinishButton.Name = "FinishButton";
			this.FinishButton.Size = new System.Drawing.Size(100, 48);
			this.FinishButton.TabIndex = 5;
			this.FinishButton.Text = "Finish";
			this.FinishButton.UseVisualStyleBackColor = true;
			// 
			// PreviousButton
			// 
			this.PreviousButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PreviousButton.Location = new System.Drawing.Point(10, 392);
			this.PreviousButton.Margin = new System.Windows.Forms.Padding(10);
			this.PreviousButton.Name = "PreviousButton";
			this.PreviousButton.Size = new System.Drawing.Size(100, 48);
			this.PreviousButton.TabIndex = 4;
			this.PreviousButton.Text = "Previous";
			this.PreviousButton.UseVisualStyleBackColor = true;
			// 
			// OpenImageFileDialog
			// 
			this.OpenImageFileDialog.FileName = "openFileDialog1";
			// 
			// BuildQuestion
			// 
			this.TableLayout.SetColumnSpan(this.BuildQuestion, 4);
			this.BuildQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BuildQuestion.Location = new System.Drawing.Point(3, 3);
			this.BuildQuestion.Name = "BuildQuestion";
			this.TableLayout.SetRowSpan(this.BuildQuestion, 3);
			this.BuildQuestion.Size = new System.Drawing.Size(794, 376);
			this.BuildQuestion.TabIndex = 14;
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
		private UserControls.QuestionBuilderUC BuildQuestion;
	}
}