namespace Attendance_Scanning
{
    partial class PasswordEditor
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
            this.Enter_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OldBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.NewBox = new System.Windows.Forms.TextBox();
            this.New_PaswordLabel1 = new System.Windows.Forms.Label();
            this.ReenterBox = new System.Windows.Forms.TextBox();
            this.ReEnter_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(190, 209);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(76, 29);
            this.Enter_Button.TabIndex = 7;
            this.Enter_Button.Text = "Enter";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(14, 209);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(80, 29);
            this.Cancel_Button.TabIndex = 6;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OldBox
            // 
            this.OldBox.Location = new System.Drawing.Point(15, 30);
            this.OldBox.Name = "OldBox";
            this.OldBox.PasswordChar = '*';
            this.OldBox.Size = new System.Drawing.Size(258, 28);
            this.OldBox.TabIndex = 5;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(12, 8);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(125, 18);
            this.Password_Label.TabIndex = 4;
            this.Password_Label.Text = "Old Password:";
            // 
            // NewBox
            // 
            this.NewBox.Location = new System.Drawing.Point(15, 91);
            this.NewBox.Name = "NewBox";
            this.NewBox.PasswordChar = '*';
            this.NewBox.Size = new System.Drawing.Size(258, 28);
            this.NewBox.TabIndex = 9;
            // 
            // New_PaswordLabel1
            // 
            this.New_PaswordLabel1.AutoSize = true;
            this.New_PaswordLabel1.Location = new System.Drawing.Point(12, 71);
            this.New_PaswordLabel1.Name = "New_PaswordLabel1";
            this.New_PaswordLabel1.Size = new System.Drawing.Size(125, 18);
            this.New_PaswordLabel1.TabIndex = 8;
            this.New_PaswordLabel1.Text = "New Password:";
            // 
            // ReenterBox
            // 
            this.ReenterBox.Location = new System.Drawing.Point(15, 156);
            this.ReenterBox.Name = "ReenterBox";
            this.ReenterBox.PasswordChar = '*';
            this.ReenterBox.Size = new System.Drawing.Size(258, 28);
            this.ReenterBox.TabIndex = 11;
            // 
            // ReEnter_Label
            // 
            this.ReEnter_Label.AutoSize = true;
            this.ReEnter_Label.Location = new System.Drawing.Point(12, 134);
            this.ReEnter_Label.Name = "ReEnter_Label";
            this.ReEnter_Label.Size = new System.Drawing.Size(242, 18);
            this.ReEnter_Label.TabIndex = 10;
            this.ReEnter_Label.Text = "reenter your New Password:";
            // 
            // PasswordEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.ReenterBox);
            this.Controls.Add(this.ReEnter_Label);
            this.Controls.Add(this.NewBox);
            this.Controls.Add(this.New_PaswordLabel1);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OldBox);
            this.Controls.Add(this.Password_Label);
            this.Name = "PasswordEditor";
            this.Text = "PasswordEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox OldBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox NewBox;
        private System.Windows.Forms.Label New_PaswordLabel1;
        private System.Windows.Forms.TextBox ReenterBox;
        private System.Windows.Forms.Label ReEnter_Label;
    }
}