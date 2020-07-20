namespace Exam.Forms
{
    partial class AlertMessage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.warningLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.okBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancleBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.warningLable, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.61147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.38853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 180);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(235, 135);
            this.okBtn.Margin = new System.Windows.Forms.Padding(50, 5, 25, 5);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(110, 40);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancleBtn
            // 
            this.cancleBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleBtn.Location = new System.Drawing.Point(25, 135);
            this.cancleBtn.Margin = new System.Windows.Forms.Padding(25, 5, 50, 5);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(110, 40);
            this.cancleBtn.TabIndex = 1;
            this.cancleBtn.Text = "Cancle";
            this.cancleBtn.UseVisualStyleBackColor = true;
            // 
            // warningLable
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.warningLable, 2);
            this.warningLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warningLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLable.Location = new System.Drawing.Point(3, 0);
            this.warningLable.Name = "warningLable";
            this.warningLable.Size = new System.Drawing.Size(364, 130);
            this.warningLable.TabIndex = 2;
            this.warningLable.Text = "By clicking OK you will start the test. You Will not be able to go back without f" +
    "inishing.";
            this.warningLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 180);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AlertMessage";
            this.Text = "AlertMessage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancleBtn;
        private System.Windows.Forms.Label warningLable;
    }
}