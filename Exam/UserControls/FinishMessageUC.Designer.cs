namespace Exam.UserControls
{
	partial class FinishMessageUC
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
			this.AttentionLabel = new System.Windows.Forms.Label();
			this.IncompleteExamLabel = new System.Windows.Forms.Label();
			this.FinishButton = new System.Windows.Forms.Button();
			this.TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 3;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout.Controls.Add(this.AttentionLabel, 0, 1);
			this.TableLayout.Controls.Add(this.IncompleteExamLabel, 0, 0);
			this.TableLayout.Controls.Add(this.FinishButton, 1, 2);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 3;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.76471F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.7647F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.47059F));
			this.TableLayout.Size = new System.Drawing.Size(758, 322);
			this.TableLayout.TabIndex = 1;
			// 
			// AttentionLabel
			// 
			this.AttentionLabel.AutoSize = true;
			this.TableLayout.SetColumnSpan(this.AttentionLabel, 3);
			this.AttentionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AttentionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.AttentionLabel.Location = new System.Drawing.Point(10, 128);
			this.AttentionLabel.Margin = new System.Windows.Forms.Padding(10);
			this.AttentionLabel.Name = "AttentionLabel";
			this.AttentionLabel.Size = new System.Drawing.Size(738, 98);
			this.AttentionLabel.TabIndex = 1;
			this.AttentionLabel.Text = "Once you hit finish,\r\nyou won’t be able to change yalls answers no more.\r\n";
			this.AttentionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IncompleteExamLabel
			// 
			this.IncompleteExamLabel.AutoSize = true;
			this.TableLayout.SetColumnSpan(this.IncompleteExamLabel, 3);
			this.IncompleteExamLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.IncompleteExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.IncompleteExamLabel.Location = new System.Drawing.Point(10, 10);
			this.IncompleteExamLabel.Margin = new System.Windows.Forms.Padding(10);
			this.IncompleteExamLabel.Name = "IncompleteExamLabel";
			this.IncompleteExamLabel.Size = new System.Drawing.Size(738, 98);
			this.IncompleteExamLabel.TabIndex = 0;
			this.IncompleteExamLabel.Text = "You have finished the test!";
			this.IncompleteExamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FinishButton
			// 
			this.FinishButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FinishButton.Location = new System.Drawing.Point(313, 246);
			this.FinishButton.Margin = new System.Windows.Forms.Padding(10);
			this.FinishButton.Name = "FinishButton";
			this.FinishButton.Size = new System.Drawing.Size(131, 66);
			this.FinishButton.TabIndex = 2;
			this.FinishButton.Text = "Finish";
			this.FinishButton.UseVisualStyleBackColor = true;
			this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
			// 
			// FinishMessageUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayout);
			this.Name = "FinishMessageUC";
			this.Size = new System.Drawing.Size(758, 322);
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Label AttentionLabel;
		private System.Windows.Forms.Label IncompleteExamLabel;
		private System.Windows.Forms.Button FinishButton;
	}
}
