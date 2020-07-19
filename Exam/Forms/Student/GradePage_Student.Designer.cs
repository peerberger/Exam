namespace Exam.Student
{
	partial class GradePage_Student
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
            this.GradeLabel = new System.Windows.Forms.Label();
            this.GradeMessageLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 3;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout.Controls.Add(this.GradeLabel, 1, 1);
            this.TableLayout.Controls.Add(this.GradeMessageLabel, 1, 0);
            this.TableLayout.Controls.Add(this.okButton, 1, 2);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 3;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayout.Size = new System.Drawing.Size(295, 256);
            this.TableLayout.TabIndex = 0;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GradeLabel.Location = new System.Drawing.Point(101, 88);
            this.GradeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(92, 79);
            this.GradeLabel.TabIndex = 1;
            this.GradeLabel.Text = "99";
            this.GradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradeMessageLabel
            // 
            this.GradeMessageLabel.AutoSize = true;
            this.GradeMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradeMessageLabel.Location = new System.Drawing.Point(101, 3);
            this.GradeMessageLabel.Margin = new System.Windows.Forms.Padding(3);
            this.GradeMessageLabel.Name = "GradeMessageLabel";
            this.GradeMessageLabel.Size = new System.Drawing.Size(92, 79);
            this.GradeMessageLabel.TabIndex = 0;
            this.GradeMessageLabel.Text = "Yalls grade is:\r\n";
            this.GradeMessageLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(101, 173);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(92, 80);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // GradePage_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 256);
            this.Controls.Add(this.TableLayout);
            this.Name = "GradePage_Student";
            this.Text = "Exam App";
            this.TableLayout.ResumeLayout(false);
            this.TableLayout.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Label GradeLabel;
		private System.Windows.Forms.Label GradeMessageLabel;
        private System.Windows.Forms.Button okButton;
    }
}