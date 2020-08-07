namespace Exam.UserControls
{
	partial class AnswerOptionUC
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
			this.DeleteButton = new System.Windows.Forms.Button();
			this.AnswerTextBox = new System.Windows.Forms.TextBox();
			this.TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 2;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.TableLayout.Controls.Add(this.DeleteButton, 1, 0);
			this.TableLayout.Controls.Add(this.AnswerTextBox, 0, 0);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 1;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayout.Size = new System.Drawing.Size(270, 25);
			this.TableLayout.TabIndex = 0;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DeleteButton.Location = new System.Drawing.Point(220, 0);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(50, 25);
			this.DeleteButton.TabIndex = 0;
			this.DeleteButton.Text = "X";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// AnswerTextBox
			// 
			this.AnswerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AnswerTextBox.Location = new System.Drawing.Point(0, 0);
			this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.AnswerTextBox.Multiline = true;
			this.AnswerTextBox.Name = "AnswerTextBox";
			this.AnswerTextBox.Size = new System.Drawing.Size(220, 25);
			this.AnswerTextBox.TabIndex = 1;
			// 
			// AnswerOptionUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayout);
			this.MinimumSize = new System.Drawing.Size(270, 25);
			this.Name = "AnswerOptionUC";
			this.Size = new System.Drawing.Size(270, 25);
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.TextBox AnswerTextBox;
	}
}
