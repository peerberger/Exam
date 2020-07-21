namespace Exam.Student
{
	partial class QuestionUC
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
			this.AnswersFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.Answer1RadioButton = new System.Windows.Forms.RadioButton();
			this.Answer2RadioButton = new System.Windows.Forms.RadioButton();
			this.Answer3RadioButton = new System.Windows.Forms.RadioButton();
			this.Answer4RadioButton = new System.Windows.Forms.RadioButton();
			this.QuestionTextBox = new System.Windows.Forms.TextBox();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.TableLayout.SuspendLayout();
			this.AnswersFlowLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 1;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayout.Controls.Add(this.AnswersFlowLayout, 0, 2);
			this.TableLayout.Controls.Add(this.QuestionTextBox, 0, 1);
			this.TableLayout.Controls.Add(this.DescriptionTextBox, 0, 0);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 3;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.TableLayout.Size = new System.Drawing.Size(800, 322);
			this.TableLayout.TabIndex = 2;
			// 
			// AnswersFlowLayout
			// 
			this.AnswersFlowLayout.Controls.Add(this.Answer1RadioButton);
			this.AnswersFlowLayout.Controls.Add(this.Answer2RadioButton);
			this.AnswersFlowLayout.Controls.Add(this.Answer3RadioButton);
			this.AnswersFlowLayout.Controls.Add(this.Answer4RadioButton);
			this.AnswersFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnswersFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.AnswersFlowLayout.Location = new System.Drawing.Point(0, 128);
			this.AnswersFlowLayout.Margin = new System.Windows.Forms.Padding(0);
			this.AnswersFlowLayout.Name = "AnswersFlowLayout";
			this.AnswersFlowLayout.Size = new System.Drawing.Size(800, 194);
			this.AnswersFlowLayout.TabIndex = 4;
			// 
			// Answer1RadioButton
			// 
			this.Answer1RadioButton.AutoSize = true;
			this.Answer1RadioButton.Location = new System.Drawing.Point(10, 10);
			this.Answer1RadioButton.Margin = new System.Windows.Forms.Padding(10);
			this.Answer1RadioButton.Name = "Answer1RadioButton";
			this.Answer1RadioButton.Size = new System.Drawing.Size(48, 17);
			this.Answer1RadioButton.TabIndex = 0;
			this.Answer1RadioButton.Text = "This.";
			this.Answer1RadioButton.UseVisualStyleBackColor = true;
			// 
			// Answer2RadioButton
			// 
			this.Answer2RadioButton.AutoSize = true;
			this.Answer2RadioButton.Location = new System.Drawing.Point(10, 47);
			this.Answer2RadioButton.Margin = new System.Windows.Forms.Padding(10);
			this.Answer2RadioButton.Name = "Answer2RadioButton";
			this.Answer2RadioButton.Size = new System.Drawing.Size(50, 17);
			this.Answer2RadioButton.TabIndex = 1;
			this.Answer2RadioButton.Text = "That.";
			this.Answer2RadioButton.UseVisualStyleBackColor = true;
			// 
			// Answer3RadioButton
			// 
			this.Answer3RadioButton.AutoSize = true;
			this.Answer3RadioButton.Location = new System.Drawing.Point(10, 84);
			this.Answer3RadioButton.Margin = new System.Windows.Forms.Padding(10);
			this.Answer3RadioButton.Name = "Answer3RadioButton";
			this.Answer3RadioButton.Size = new System.Drawing.Size(75, 17);
			this.Answer3RadioButton.TabIndex = 2;
			this.Answer3RadioButton.Text = "Whatever.";
			this.Answer3RadioButton.UseVisualStyleBackColor = true;
			// 
			// Answer4RadioButton
			// 
			this.Answer4RadioButton.AutoSize = true;
			this.Answer4RadioButton.Location = new System.Drawing.Point(10, 121);
			this.Answer4RadioButton.Margin = new System.Windows.Forms.Padding(10);
			this.Answer4RadioButton.Name = "Answer4RadioButton";
			this.Answer4RadioButton.Size = new System.Drawing.Size(97, 17);
			this.Answer4RadioButton.TabIndex = 3;
			this.Answer4RadioButton.Text = "Dolla dolla bills.";
			this.Answer4RadioButton.UseVisualStyleBackColor = true;
			// 
			// QuestionTextBox
			// 
			this.QuestionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionTextBox.Location = new System.Drawing.Point(10, 42);
			this.QuestionTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.QuestionTextBox.Multiline = true;
			this.QuestionTextBox.Name = "QuestionTextBox";
			this.QuestionTextBox.Size = new System.Drawing.Size(780, 76);
			this.QuestionTextBox.TabIndex = 3;
			this.QuestionTextBox.Text = "When and what did who do for how much?";
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DescriptionTextBox.Location = new System.Drawing.Point(10, 10);
			this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(780, 20);
			this.DescriptionTextBox.TabIndex = 5;
			// 
			// QuestionUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayout);
			this.Name = "QuestionUC";
			this.Size = new System.Drawing.Size(800, 322);
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.AnswersFlowLayout.ResumeLayout(false);
			this.AnswersFlowLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.TextBox QuestionTextBox;
		private System.Windows.Forms.FlowLayoutPanel AnswersFlowLayout;
		private System.Windows.Forms.RadioButton Answer1RadioButton;
		private System.Windows.Forms.RadioButton Answer2RadioButton;
		private System.Windows.Forms.RadioButton Answer3RadioButton;
		private System.Windows.Forms.RadioButton Answer4RadioButton;
        private System.Windows.Forms.TextBox DescriptionTextBox;
    }
}
