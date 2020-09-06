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
			this.RightAnswerTextBox = new System.Windows.Forms.TextBox();
			this.QuestionTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.QuestionTypeLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.MultipleOptionsRadioButton = new System.Windows.Forms.RadioButton();
			this.OpenTextRadioButton = new System.Windows.Forms.RadioButton();
			this.AddImageButton = new System.Windows.Forms.Button();
			this.AnswersFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.QuestionTextBox = new System.Windows.Forms.TextBox();
			this.AnswerTextBox = new System.Windows.Forms.TextBox();
			this.AddOptionButton = new System.Windows.Forms.Button();
			this.DescriptionComboBox = new System.Windows.Forms.ComboBox();
			this.QuestionPictureBox = new System.Windows.Forms.PictureBox();
			this.TableLayout.SuspendLayout();
			this.QuestionTypeGroupBox.SuspendLayout();
			this.QuestionTypeLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 3;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayout.Controls.Add(this.RightAnswerTextBox, 1, 1);
			this.TableLayout.Controls.Add(this.QuestionTypeGroupBox, 2, 2);
			this.TableLayout.Controls.Add(this.AddImageButton, 2, 0);
			this.TableLayout.Controls.Add(this.AnswersFlowLayout, 0, 2);
			this.TableLayout.Controls.Add(this.QuestionTextBox, 0, 1);
			this.TableLayout.Controls.Add(this.AnswerTextBox, 1, 2);
			this.TableLayout.Controls.Add(this.AddOptionButton, 1, 3);
			this.TableLayout.Controls.Add(this.DescriptionComboBox, 0, 0);
			this.TableLayout.Controls.Add(this.QuestionPictureBox, 2, 1);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 4;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayout.Size = new System.Drawing.Size(653, 415);
			this.TableLayout.TabIndex = 3;
			// 
			// RightAnswerTextBox
			// 
			this.RightAnswerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RightAnswerTextBox.Location = new System.Drawing.Point(271, 51);
			this.RightAnswerTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.RightAnswerTextBox.Multiline = true;
			this.RightAnswerTextBox.Name = "RightAnswerTextBox";
			this.RightAnswerTextBox.Size = new System.Drawing.Size(241, 104);
			this.RightAnswerTextBox.TabIndex = 20;
			this.RightAnswerTextBox.Text = "Write the right answer here...";
			// 
			// QuestionTypeGroupBox
			// 
			this.QuestionTypeGroupBox.Controls.Add(this.QuestionTypeLayoutPanel);
			this.QuestionTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionTypeGroupBox.Location = new System.Drawing.Point(532, 175);
			this.QuestionTypeGroupBox.Margin = new System.Windows.Forms.Padding(10);
			this.QuestionTypeGroupBox.Name = "QuestionTypeGroupBox";
			this.TableLayout.SetRowSpan(this.QuestionTypeGroupBox, 2);
			this.QuestionTypeGroupBox.Size = new System.Drawing.Size(111, 230);
			this.QuestionTypeGroupBox.TabIndex = 18;
			this.QuestionTypeGroupBox.TabStop = false;
			this.QuestionTypeGroupBox.Text = "Question Type";
			// 
			// QuestionTypeLayoutPanel
			// 
			this.QuestionTypeLayoutPanel.ColumnCount = 1;
			this.QuestionTypeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.QuestionTypeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.QuestionTypeLayoutPanel.Controls.Add(this.MultipleOptionsRadioButton, 0, 0);
			this.QuestionTypeLayoutPanel.Controls.Add(this.OpenTextRadioButton, 0, 1);
			this.QuestionTypeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionTypeLayoutPanel.Location = new System.Drawing.Point(3, 16);
			this.QuestionTypeLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.QuestionTypeLayoutPanel.Name = "QuestionTypeLayoutPanel";
			this.QuestionTypeLayoutPanel.RowCount = 2;
			this.QuestionTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.QuestionTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.QuestionTypeLayoutPanel.Size = new System.Drawing.Size(105, 211);
			this.QuestionTypeLayoutPanel.TabIndex = 2;
			// 
			// MultipleOptionsRadioButton
			// 
			this.MultipleOptionsRadioButton.AutoSize = true;
			this.MultipleOptionsRadioButton.Checked = true;
			this.MultipleOptionsRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MultipleOptionsRadioButton.Location = new System.Drawing.Point(10, 10);
			this.MultipleOptionsRadioButton.Margin = new System.Windows.Forms.Padding(10);
			this.MultipleOptionsRadioButton.Name = "MultipleOptionsRadioButton";
			this.MultipleOptionsRadioButton.Size = new System.Drawing.Size(85, 85);
			this.MultipleOptionsRadioButton.TabIndex = 0;
			this.MultipleOptionsRadioButton.TabStop = true;
			this.MultipleOptionsRadioButton.Text = "Multiple Options";
			this.MultipleOptionsRadioButton.UseVisualStyleBackColor = true;
			this.MultipleOptionsRadioButton.CheckedChanged += new System.EventHandler(this.MultipleOptionsRadioButton_CheckedChanged);
			// 
			// OpenTextRadioButton
			// 
			this.OpenTextRadioButton.AutoSize = true;
			this.OpenTextRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OpenTextRadioButton.Location = new System.Drawing.Point(10, 115);
			this.OpenTextRadioButton.Margin = new System.Windows.Forms.Padding(10);
			this.OpenTextRadioButton.Name = "OpenTextRadioButton";
			this.OpenTextRadioButton.Size = new System.Drawing.Size(85, 86);
			this.OpenTextRadioButton.TabIndex = 1;
			this.OpenTextRadioButton.Text = "Open Text";
			this.OpenTextRadioButton.UseVisualStyleBackColor = true;
			this.OpenTextRadioButton.CheckedChanged += new System.EventHandler(this.OpenTextRadioButton_CheckedChanged);
			// 
			// AddImageButton
			// 
			this.AddImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddImageButton.Location = new System.Drawing.Point(532, 10);
			this.AddImageButton.Margin = new System.Windows.Forms.Padding(10);
			this.AddImageButton.Name = "AddImageButton";
			this.AddImageButton.Size = new System.Drawing.Size(111, 21);
			this.AddImageButton.TabIndex = 17;
			this.AddImageButton.Text = "Add Image";
			this.AddImageButton.UseVisualStyleBackColor = true;
			this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
			// 
			// AnswersFlowLayout
			// 
			this.AnswersFlowLayout.AutoScroll = true;
			this.AnswersFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnswersFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.AnswersFlowLayout.Location = new System.Drawing.Point(0, 165);
			this.AnswersFlowLayout.Margin = new System.Windows.Forms.Padding(0);
			this.AnswersFlowLayout.Name = "AnswersFlowLayout";
			this.AnswersFlowLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TableLayout.SetRowSpan(this.AnswersFlowLayout, 2);
			this.AnswersFlowLayout.Size = new System.Drawing.Size(261, 250);
			this.AnswersFlowLayout.TabIndex = 4;
			// 
			// QuestionTextBox
			// 
			this.QuestionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionTextBox.Location = new System.Drawing.Point(10, 51);
			this.QuestionTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.QuestionTextBox.Multiline = true;
			this.QuestionTextBox.Name = "QuestionTextBox";
			this.QuestionTextBox.Size = new System.Drawing.Size(241, 104);
			this.QuestionTextBox.TabIndex = 3;
			this.QuestionTextBox.Text = "When and what did who do for how much?";
			// 
			// AnswerTextBox
			// 
			this.AnswerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnswerTextBox.Location = new System.Drawing.Point(271, 175);
			this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(10);
			this.AnswerTextBox.Multiline = true;
			this.AnswerTextBox.Name = "AnswerTextBox";
			this.AnswerTextBox.Size = new System.Drawing.Size(241, 146);
			this.AnswerTextBox.TabIndex = 6;
			this.AnswerTextBox.Text = "Write an answer...";
			// 
			// AddOptionButton
			// 
			this.AddOptionButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddOptionButton.Location = new System.Drawing.Point(271, 341);
			this.AddOptionButton.Margin = new System.Windows.Forms.Padding(10);
			this.AddOptionButton.Name = "AddOptionButton";
			this.AddOptionButton.Size = new System.Drawing.Size(241, 64);
			this.AddOptionButton.TabIndex = 7;
			this.AddOptionButton.Text = "Add Option";
			this.AddOptionButton.UseVisualStyleBackColor = true;
			this.AddOptionButton.Click += new System.EventHandler(this.AddOptionButton_Click);
			// 
			// DescriptionComboBox
			// 
			this.TableLayout.SetColumnSpan(this.DescriptionComboBox, 2);
			this.DescriptionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DescriptionComboBox.FormattingEnabled = true;
			this.DescriptionComboBox.Location = new System.Drawing.Point(10, 10);
			this.DescriptionComboBox.Margin = new System.Windows.Forms.Padding(10);
			this.DescriptionComboBox.Name = "DescriptionComboBox";
			this.DescriptionComboBox.Size = new System.Drawing.Size(502, 21);
			this.DescriptionComboBox.TabIndex = 19;
			// 
			// QuestionPictureBox
			// 
			this.QuestionPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuestionPictureBox.Location = new System.Drawing.Point(532, 51);
			this.QuestionPictureBox.Margin = new System.Windows.Forms.Padding(10);
			this.QuestionPictureBox.Name = "QuestionPictureBox";
			this.QuestionPictureBox.Size = new System.Drawing.Size(111, 104);
			this.QuestionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.QuestionPictureBox.TabIndex = 21;
			this.QuestionPictureBox.TabStop = false;
			// 
			// QuestionBuilderUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayout);
			this.Name = "QuestionBuilderUC";
			this.Size = new System.Drawing.Size(653, 415);
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.QuestionTypeGroupBox.ResumeLayout(false);
			this.QuestionTypeLayoutPanel.ResumeLayout(false);
			this.QuestionTypeLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.FlowLayoutPanel AnswersFlowLayout;
		private System.Windows.Forms.TextBox QuestionTextBox;
		private System.Windows.Forms.Button AddImageButton;
		private System.Windows.Forms.GroupBox QuestionTypeGroupBox;
		private System.Windows.Forms.TableLayoutPanel QuestionTypeLayoutPanel;
		private System.Windows.Forms.RadioButton MultipleOptionsRadioButton;
		private System.Windows.Forms.RadioButton OpenTextRadioButton;
		private System.Windows.Forms.ComboBox DescriptionComboBox;
		private System.Windows.Forms.TextBox RightAnswerTextBox;
		private System.Windows.Forms.TextBox AnswerTextBox;
		private System.Windows.Forms.Button AddOptionButton;
		private System.Windows.Forms.PictureBox QuestionPictureBox;
	}
}
