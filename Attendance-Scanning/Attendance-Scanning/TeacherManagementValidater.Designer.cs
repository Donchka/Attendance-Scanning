namespace Attendance_Scanning
{
    partial class TeacherManagementValidater
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
            this.Password_Label = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(9, 9);
            this.Password_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(136, 13);
            this.Password_Label.TabIndex = 0;
            this.Password_Label.Text = "Password: (Default is aaaa)";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(11, 25);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '·';
            this.PasswordBox.Size = new System.Drawing.Size(266, 20);
            this.PasswordBox.TabIndex = 1;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(9, 50);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(62, 29);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(218, 50);
            this.Enter_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(59, 29);
            this.Enter_Button.TabIndex = 3;
            this.Enter_Button.Text = "Enter";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // TeacherManagementValidater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 90);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Password_Label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeacherManagementValidater";
            this.Text = "TeacherManagementValidater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Enter_Button;
    }
}