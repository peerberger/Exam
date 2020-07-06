namespace Exam
{
	partial class StartPage_Student
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
			this.StartButton = new System.Windows.Forms.Button();
			this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.AttentionLabel = new System.Windows.Forms.Label();
			this.TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.StartButton.Location = new System.Drawing.Point(290, 294);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(197, 73);
			this.StartButton.TabIndex = 1;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 1;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayout.Controls.Add(this.AttentionLabel, 0, 0);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Top;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 1;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayout.Size = new System.Drawing.Size(800, 218);
			this.TableLayout.TabIndex = 3;
			// 
			// AttentionLabel
			// 
			this.AttentionLabel.AutoSize = true;
			this.AttentionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AttentionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.AttentionLabel.Location = new System.Drawing.Point(10, 10);
			this.AttentionLabel.Margin = new System.Windows.Forms.Padding(10);
			this.AttentionLabel.Name = "AttentionLabel";
			this.AttentionLabel.Size = new System.Drawing.Size(780, 198);
			this.AttentionLabel.TabIndex = 0;
			this.AttentionLabel.Text = "This exam has time limit so when you hit Start,\r\nyalls got [time limit] to finish" +
    ".";
			this.AttentionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StartPage_Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TableLayout);
			this.Controls.Add(this.StartButton);
			this.Name = "StartPage_Student";
			this.Text = "Exam App";
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Label AttentionLabel;
	}
}