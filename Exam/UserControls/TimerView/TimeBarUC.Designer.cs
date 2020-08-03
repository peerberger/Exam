namespace Exam
{
	partial class TimeBarUC
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
            this.TimeRemainingLbl = new System.Windows.Forms.Label();
            this.TimeElapsedLbl = new System.Windows.Forms.Label();
            this.TimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 3;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.Controls.Add(this.TimeRemainingLbl, 2, 0);
            this.TableLayout.Controls.Add(this.TimeElapsedLbl, 0, 0);
            this.TableLayout.Controls.Add(this.TimeProgressBar, 1, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(800, 59);
            this.TableLayout.TabIndex = 2;
            // 
            // TimeRemainingLbl
            // 
            this.TimeRemainingLbl.AutoSize = true;
            this.TimeRemainingLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeRemainingLbl.Location = new System.Drawing.Point(738, 10);
            this.TimeRemainingLbl.Margin = new System.Windows.Forms.Padding(10);
            this.TimeRemainingLbl.Name = "TimeRemainingLbl";
            this.TimeRemainingLbl.Size = new System.Drawing.Size(52, 39);
            this.TimeRemainingLbl.TabIndex = 1;
            this.TimeRemainingLbl.Text = "30:00";
            this.TimeRemainingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeElapsedLbl
            // 
            this.TimeElapsedLbl.AutoSize = true;
            this.TimeElapsedLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeElapsedLbl.Location = new System.Drawing.Point(10, 10);
            this.TimeElapsedLbl.Margin = new System.Windows.Forms.Padding(10);
            this.TimeElapsedLbl.Name = "TimeElapsedLbl";
            this.TimeElapsedLbl.Size = new System.Drawing.Size(52, 39);
            this.TimeElapsedLbl.TabIndex = 0;
            this.TimeElapsedLbl.Text = "14:34";
            this.TimeElapsedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeProgressBar
            // 
            this.TimeProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeProgressBar.Location = new System.Drawing.Point(82, 10);
            this.TimeProgressBar.Margin = new System.Windows.Forms.Padding(10);
            this.TimeProgressBar.Name = "TimeProgressBar";
            this.TimeProgressBar.Size = new System.Drawing.Size(636, 39);
            this.TimeProgressBar.TabIndex = 2;
            // 
            // TimeBarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayout);
            this.Name = "TimeBarUC";
            this.Size = new System.Drawing.Size(800, 59);
            this.TableLayout.ResumeLayout(false);
            this.TableLayout.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Label TimeRemainingLbl;
		private System.Windows.Forms.Label TimeElapsedLbl;
		private System.Windows.Forms.ProgressBar TimeProgressBar;
	}
}
