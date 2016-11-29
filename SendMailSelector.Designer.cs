namespace Attendance_Scanning
{
    partial class SendMailSelector
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
            this.Send = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Absent_Student_Checkbox = new System.Windows.Forms.CheckBox();
            this.Unchecked_Students_Checkbox = new System.Windows.Forms.CheckBox();
            this.Late_Students_Checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(2, 207);
            this.Send.Margin = new System.Windows.Forms.Padding(2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(50, 20);
            this.Send.TabIndex = 0;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(2, 180);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(50, 20);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Absent_Student_Checkbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Unchecked_Students_Checkbox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Send, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Late_Students_Checkbox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.63025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.36975F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 235);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Absent_Student_Checkbox
            // 
            this.Absent_Student_Checkbox.AutoSize = true;
            this.Absent_Student_Checkbox.Location = new System.Drawing.Point(3, 94);
            this.Absent_Student_Checkbox.Name = "Absent_Student_Checkbox";
            this.Absent_Student_Checkbox.Size = new System.Drawing.Size(104, 17);
            this.Absent_Student_Checkbox.TabIndex = 0;
            this.Absent_Student_Checkbox.Text = "Absent Students";
            this.Absent_Student_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Unchecked_Students_Checkbox
            // 
            this.Unchecked_Students_Checkbox.AutoSize = true;
            this.Unchecked_Students_Checkbox.Location = new System.Drawing.Point(3, 123);
            this.Unchecked_Students_Checkbox.Name = "Unchecked_Students_Checkbox";
            this.Unchecked_Students_Checkbox.Size = new System.Drawing.Size(127, 17);
            this.Unchecked_Students_Checkbox.TabIndex = 1;
            this.Unchecked_Students_Checkbox.Text = "Unchecked Students";
            this.Unchecked_Students_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Late_Students_Checkbox
            // 
            this.Late_Students_Checkbox.AutoSize = true;
            this.Late_Students_Checkbox.Location = new System.Drawing.Point(3, 152);
            this.Late_Students_Checkbox.Name = "Late_Students_Checkbox";
            this.Late_Students_Checkbox.Size = new System.Drawing.Size(92, 17);
            this.Late_Students_Checkbox.TabIndex = 2;
            this.Late_Students_Checkbox.Text = "Late Students";
            this.Late_Students_Checkbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which type of Students would you like to email?";
            // 
            // SendMailSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SendMailSelector";
            this.Text = "SendMailSelector";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox Absent_Student_Checkbox;
        public System.Windows.Forms.CheckBox Unchecked_Students_Checkbox;
        public System.Windows.Forms.CheckBox Late_Students_Checkbox;
    }
}