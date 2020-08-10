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
			this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.StartButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).BeginInit();
			this.TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// GradesGridView
			// 
			this.GradesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GradesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GradesGridView.Location = new System.Drawing.Point(81, 57);
			this.GradesGridView.Margin = new System.Windows.Forms.Padding(10);
			this.GradesGridView.Name = "GradesGridView";
			this.GradesGridView.ReadOnly = true;
			this.TableLayout.SetRowSpan(this.GradesGridView, 3);
			this.GradesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GradesGridView.Size = new System.Drawing.Size(229, 201);
			this.GradesGridView.TabIndex = 4;
			this.GradesGridView.SelectionChanged += new System.EventHandler(this.examsGridView_SelectionChanged);
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
			this.StartButton.Location = new System.Drawing.Point(359, 120);
			this.StartButton.Margin = new System.Windows.Forms.Padding(10);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(152, 75);
			this.StartButton.TabIndex = 3;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// WelcomeStudentViewUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TableLayout);
			this.Name = "WelcomeStudentViewUC";
			this.Size = new System.Drawing.Size(595, 317);
			((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).EndInit();
			this.TableLayout.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView GradesGridView;
		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Button StartButton;
	}
}
