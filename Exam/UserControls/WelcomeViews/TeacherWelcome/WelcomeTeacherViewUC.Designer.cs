namespace Exam.UserControls
{
	partial class WelcomeTeacherViewUC
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
            this.ClassroomsComboBox = new System.Windows.Forms.ComboBox();
            this.BuildTestButton = new System.Windows.Forms.Button();
            this.ExamsComboBox = new System.Windows.Forms.ComboBox();
            this.GradesGridView = new System.Windows.Forms.DataGridView();
            this.TableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 6;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TableLayout.Controls.Add(this.ClassroomsComboBox, 1, 1);
            this.TableLayout.Controls.Add(this.BuildTestButton, 4, 3);
            this.TableLayout.Controls.Add(this.ExamsComboBox, 2, 1);
            this.TableLayout.Controls.Add(this.GradesGridView, 1, 3);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 6;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.Size = new System.Drawing.Size(611, 330);
            this.TableLayout.TabIndex = 6;
            // 
            // ClassroomsComboBox
            // 
            this.ClassroomsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassroomsComboBox.FormattingEnabled = true;
            this.ClassroomsComboBox.Location = new System.Drawing.Point(83, 59);
            this.ClassroomsComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.ClassroomsComboBox.Name = "ClassroomsComboBox";
            this.ClassroomsComboBox.Size = new System.Drawing.Size(108, 21);
            this.ClassroomsComboBox.TabIndex = 6;
            this.ClassroomsComboBox.Text = "Classrooms";
            this.ClassroomsComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassroomsComboBox_SelectedIndexChanged);
            // 
            // BuildTestButton
            // 
            this.BuildTestButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.BuildTestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BuildTestButton.Location = new System.Drawing.Point(369, 125);
            this.BuildTestButton.Margin = new System.Windows.Forms.Padding(10);
            this.BuildTestButton.Name = "BuildTestButton";
            this.BuildTestButton.Size = new System.Drawing.Size(157, 79);
            this.BuildTestButton.TabIndex = 3;
            this.BuildTestButton.Text = "Build a Test";
            this.BuildTestButton.UseVisualStyleBackColor = true;
            this.BuildTestButton.Click += new System.EventHandler(this.BuildTestButton_Click);
            // 
            // ExamsComboBox
            // 
            this.ExamsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExamsComboBox.FormattingEnabled = true;
            this.ExamsComboBox.Location = new System.Drawing.Point(211, 59);
            this.ExamsComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.ExamsComboBox.Name = "ExamsComboBox";
            this.ExamsComboBox.Size = new System.Drawing.Size(108, 21);
            this.ExamsComboBox.TabIndex = 5;
            this.ExamsComboBox.Text = "Exams";
            this.ExamsComboBox.SelectedIndexChanged += new System.EventHandler(this.ExamsComboBox_SelectedIndexChanged);
            // 
            // GradesGridView
            // 
            this.GradesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GradesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLayout.SetColumnSpan(this.GradesGridView, 2);
            this.GradesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradesGridView.Location = new System.Drawing.Point(76, 118);
            this.GradesGridView.MultiSelect = false;
            this.GradesGridView.Name = "GradesGridView";
            this.TableLayout.SetRowSpan(this.GradesGridView, 2);
            this.GradesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GradesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GradesGridView.Size = new System.Drawing.Size(250, 159);
            this.GradesGridView.TabIndex = 7;
            // 
            // WelcomeTeacherViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayout);
            this.Name = "WelcomeTeacherViewUC";
            this.Size = new System.Drawing.Size(611, 330);
            this.TableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GradesGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Button BuildTestButton;
		private System.Windows.Forms.ComboBox ExamsComboBox;
		private System.Windows.Forms.ComboBox ClassroomsComboBox;
        private System.Windows.Forms.DataGridView GradesGridView;
    }
}
