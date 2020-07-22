namespace Exam.UserControls
{
	partial class WelcomeStudentViewUC
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
			this.GradesGridView = new System.Windows.Forms.DataGridView();
			this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.StartButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).BeginInit();
			this.TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// GradesGridView
			// 
			this.GradesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GradesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Test,
            this.Grade});
			this.GradesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GradesGridView.Location = new System.Drawing.Point(81, 68);
			this.GradesGridView.Margin = new System.Windows.Forms.Padding(10);
			this.GradesGridView.Name = "GradesGridView";
			this.TableLayout.SetRowSpan(this.GradesGridView, 3);
			this.GradesGridView.Size = new System.Drawing.Size(229, 196);
			this.GradesGridView.TabIndex = 4;
			// 
			// Test
			// 
			this.Test.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Test.HeaderText = "Test";
			this.Test.Name = "Test";
			// 
			// Grade
			// 
			this.Grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Grade.HeaderText = "Grade";
			this.Grade.Name = "Grade";
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 5;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
			this.TableLayout.Controls.Add(this.GradesGridView, 1, 1);
			this.TableLayout.Controls.Add(this.StartButton, 3, 2);
			this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout.Location = new System.Drawing.Point(0, 0);
			this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 5;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayout.Size = new System.Drawing.Size(595, 317);
			this.TableLayout.TabIndex = 5;
			// 
			// StartButton
			// 
			this.StartButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.StartButton.Location = new System.Drawing.Point(359, 136);
			this.StartButton.Margin = new System.Windows.Forms.Padding(10);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(152, 69);
			this.StartButton.TabIndex = 3;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			// 
			// WelcomeStudentUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayout);
			this.Name = "WelcomeStudentUC";
			this.Size = new System.Drawing.Size(595, 317);
			((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).EndInit();
			this.TableLayout.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView GradesGridView;
		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn Test;
		private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
	}
}
