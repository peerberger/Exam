namespace Exam.UserControls
{
    partial class StudentWelcomePageUC
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
            this.startButton = new System.Windows.Forms.Button();
            this.examsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.examsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(367, 69);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(183, 63);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Exam";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // examsGridView
            // 
            this.examsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examsGridView.Location = new System.Drawing.Point(24, 38);
            this.examsGridView.Name = "examsGridView";
            this.examsGridView.ReadOnly = true;
            this.examsGridView.Size = new System.Drawing.Size(299, 252);
            this.examsGridView.TabIndex = 2;
            // 
            // StudentWelcomePageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.examsGridView);
            this.Controls.Add(this.startButton);
            this.Name = "StudentWelcomePageUC";
            this.Size = new System.Drawing.Size(606, 327);
            ((System.ComponentModel.ISupportInitialize)(this.examsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView examsGridView;
    }
}
