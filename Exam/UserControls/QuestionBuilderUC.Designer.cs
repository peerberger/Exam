namespace Exam.UserControls
{
	partial class QuestionBuilderUC
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
			this.QuestionTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.QuestionTypeLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.MultipeOptionsRadioButton = new System.Windows.Forms.RadioButton();
			this.OpenTextRadioButton = new System.Windows.Forms.RadioButton();
			this.AddImageButton = new System.Windows.Forms.Button();
			this.AnswersFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.Answer1RadioButton = new System.Windows.Forms.RadioButton();
			this.Answer2RadioButton = new System.Windows.Forms.RadioButton();
			this.Answer3RadioButton = new System.Windows.Forms.RadioButton();
			this.Answer4RadioButton = new System.Windows.Forms.RadioButton();
			this.QuestionTextBox = new System.Windows.Forms.TextBox();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.AnswerTextBox = new System.Windows.Forms.TextBox();
			this.AddOptionButton = new System.Windows.Forms.Button();
			this.TableLayout.SuspendLayout();
			this.QuestionTypeGroupBox.SuspendLayout();
			this.QuestionTypeLayoutPanel.SuspendLayout();
			this.AnswersFlowLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 3;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayout.Controls.Add(this.QuestionTypeGroupBox, 2, 2);
			this.TableLayout.Controls.Add(this.AddImageButton, 2, 0);
			this.TableLayout.Controls.Add(this.AnswersFlowLayout, 0, 2);
			this.TableLayout.Controls.Add(this.QuestionTextBox, 0, 1);
			this.TableLayout.Controls.Add(this.DescriptionTextBox, 0, 0);
			this.TableLayout.Controls.Add(this.AnswerTextBox, 1, 2);
			this.TableLayout.Controls.Add(this.AddOptionButton, 1, 3);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 4;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayout.Size = new System.Drawing.Size(791, 300);
			this.TableLayout.TabIndex = 3;
			// 
			// QuestionTypeGroupBox
			// 
			this.QuestionTypeGroupBox.Controls.Add(this.QuestionTypeLayoutPanel);
			this.QuestionTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionTypeGroupBox.Location = new System.Drawing.Point(642, 130);
			this.QuestionTypeGroupBox.Margin = new System.Windows.Forms.Padding(10);
			this.QuestionTypeGroupBox.Name = "QuestionTypeGroupBox";
			this.TableLayout.SetRowSpan(this.QuestionTypeGroupBox, 2);
			this.QuestionTypeGroupBox.Size = new System.Drawing.Size(139, 160);
			this.QuestionTypeGroupBox.TabIndex = 18;
			this.QuestionTypeGroupBox.TabStop = false;
			this.QuestionTypeGroupBox.Text = "Question Type";
			// 
			// QuestionTypeLayoutPanel
			// 
			this.QuestionTypeLayoutPanel.ColumnCount = 1;
			this.QuestionTypeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.QuestionTypeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.QuestionTypeLayoutPanel.Controls.Add(this.MultipeOptionsRadioButton, 0, 0);
			this.QuestionTypeLayoutPanel.Controls.Add(this.OpenTextRadioButton, 0, 1);
			this.QuestionTypeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionTypeLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.QuestionTypeLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.QuestionTypeLayoutPanel.Name = "QuestionTypeLayoutPanel";
			this.QuestionTypeLayoutPanel.RowCount = 2;
			this.QuestionTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.QuestionTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.QuestionTypeLayoutPanel.Size = new System.Drawing.Size(133, 141);
			this.QuestionTypeLayoutPanel.TabIndex = 2;
			// 
			// MultipeOptionsRadioButton
			// 
			this.MultipeOptionsRadioButton.AutoSize = true;
			this.MultipeOptionsRadioButton.Checked = true;
			this.MultipeOptionsRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MultipeOptionsRadioButton.Location = new System.Drawing.Point(10, 10);
			this.MultipeOptionsRadioButton.Margin = new System.Windows.Forms.Padding(10);
			this.MultipeOptionsRadioButton.Name = "MultipeOptionsRadioButton";
			this.MultipeOptionsRadioButton.Size = new System.Drawing.Size(113, 50);
			this.MultipeOptionsRadioButton.TabIndex = 0;
			this.MultipeOptionsRadioButton.TabStop = true;
			this.MultipeOptionsRadioButton.Text = "Multipe Options";
			this.MultipeOptionsRadioButton.UseVisualStyleBackColor = true;
			// 
			// OpenTextRadioButton
			// 
			this.OpenTextRadioButton.AutoSize = true;
			this.OpenTextRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OpenTextRadioButton.Location = new System.Drawing.Point(10, 80);
			this.OpenTextRadioButton.Margin = new System.Windows.Forms.Padding(10);
			this.OpenTextRadioButton.Name = "OpenTextRadioButton";
			this.OpenTextRadioButton.Size = new System.Drawing.Size(113, 51);
			this.OpenTextRadioButton.TabIndex = 1;
			this.OpenTextRadioButton.Text = "Open Text";
			this.OpenTextRadioButton.UseVisualStyleBackColor = true;
			// 
			// AddImageButton
			// 
			this.AddImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddImageButton.Location = new System.Drawing.Point(642, 10);
			this.AddImageButton.Margin = new System.Windows.Forms.Padding(10);
			this.AddImageButton.Name = "AddImageButton";
			this.TableLayout.SetRowSpan(this.AddImageButton, 2);
			this.AddImageButton.Size = new System.Drawing.Size(139, 100);
			this.AddImageButton.TabIndex = 17;
			this.AddImageButton.Text = "Add Image";
			this.AddImageButton.UseVisualStyleBackColor = true;
			// 
			// AnswersFlowLayout
			// 
			this.AnswersFlowLayout.Controls.Add(this.Answer1RadioButton);
			this.AnswersFlowLayout.Controls.Add(this.Answer2RadioButton);
			this.AnswersFlowLayout.Controls.Add(this.Answer3RadioButton);
			this.AnswersFlowLayout.Controls.Add(this.Answer4RadioButton);
			this.AnswersFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnswersFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.AnswersFlowLayout.Location = new System.Drawing.Point(0, 120);
			this.AnswersFlowLayout.Margin = new System.Windows.Forms.Padding(0);
			this.AnswersFlowLayout.Name = "AnswersFlowLayout";
			this.TableLayout.SetRowSpan(this.AnswersFlowLayout, 2);
			this.AnswersFlowLayout.Size = new System.Drawing.Size(316, 180);
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
			this.TableLayout.SetColumnSpan(this.QuestionTextBox, 2);
			this.QuestionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionTextBox.Location = new System.Drawing.Point(10, 40);
			this.QuestionTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.QuestionTextBox.Multiline = true;
			this.QuestionTextBox.Name = "QuestionTextBox";
			this.QuestionTextBox.Size = new System.Drawing.Size(612, 70);
			this.QuestionTextBox.TabIndex = 3;
			this.QuestionTextBox.Text = "When and what did who do for how much?";
			// 
			// DescriptionTextBox
			// 
			this.TableLayout.SetColumnSpan(this.DescriptionTextBox, 2);
			this.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DescriptionTextBox.Location = new System.Drawing.Point(10, 10);
			this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(612, 20);
			this.DescriptionTextBox.TabIndex = 5;
			this.DescriptionTextBox.Text = "Write a description...";
			// 
			// AnswerTextBox
			// 
			this.AnswerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnswerTextBox.Location = new System.Drawing.Point(326, 130);
			this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.AnswerTextBox.Multiline = true;
			this.AnswerTextBox.Name = "AnswerTextBox";
			this.AnswerTextBox.Size = new System.Drawing.Size(296, 100);
			this.AnswerTextBox.TabIndex = 6;
			this.AnswerTextBox.Text = "Write an answer...";
			// 
			// AddOptionButton
			// 
			this.AddOptionButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddOptionButton.Location = new System.Drawing.Point(326, 250);
			this.AddOptionButton.Margin = new System.Windows.Forms.Padding(10);
			this.AddOptionButton.Name = "AddOptionButton";
			this.AddOptionButton.Size = new System.Drawing.Size(296, 40);
			this.AddOptionButton.TabIndex = 7;
			this.AddOptionButton.Text = "Add Option";
			this.AddOptionButton.UseVisualStyleBackColor = true;
			// 
			// QuestionBuilderUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayout);
			this.Name = "QuestionBuilderUC";
			this.Size = new System.Drawing.Size(791, 300);
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.QuestionTypeGroupBox.ResumeLayout(false);
			this.QuestionTypeLayoutPanel.ResumeLayout(false);
			this.QuestionTypeLayoutPanel.PerformLayout();
			this.AnswersFlowLayout.ResumeLayout(false);
			this.AnswersFlowLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.FlowLayoutPanel AnswersFlowLayout;
		private System.Windows.Forms.RadioButton Answer1RadioButton;
		private System.Windows.Forms.RadioButton Answer2RadioButton;
		private System.Windows.Forms.RadioButton Answer3RadioButton;
		private System.Windows.Forms.RadioButton Answer4RadioButton;
		private System.Windows.Forms.TextBox QuestionTextBox;
		private System.Windows.Forms.TextBox DescriptionTextBox;
		private System.Windows.Forms.TextBox AnswerTextBox;
		private System.Windows.Forms.Button AddOptionButton;
		private System.Windows.Forms.Button AddImageButton;
		private System.Windows.Forms.GroupBox QuestionTypeGroupBox;
		private System.Windows.Forms.TableLayoutPanel QuestionTypeLayoutPanel;
		private System.Windows.Forms.RadioButton MultipeOptionsRadioButton;
		private System.Windows.Forms.RadioButton OpenTextRadioButton;
	}
}
