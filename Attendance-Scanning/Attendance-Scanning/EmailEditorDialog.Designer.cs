namespace Attendance_Scanning
{
    partial class EmailEditorDialog
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
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.textTO = new System.Windows.Forms.TextBox();
            this.StudentNameLabel = new System.Windows.Forms.LinkLabel();
            this.StudentLateTimeLabel = new System.Windows.Forms.LinkLabel();
            this.ClassNameLabel = new System.Windows.Forms.LinkLabel();
            this.TeacherNameLabel = new System.Windows.Forms.LinkLabel();
            this.ExapmleApplier = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(387, 425);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(91, 27);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save Format";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(8, 427);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(62, 25);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(8, 144);
            this.MessageText.Margin = new System.Windows.Forms.Padding(2);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageText.Size = new System.Drawing.Size(471, 274);
            this.MessageText.TabIndex = 2;
            // 
            // textTO
            // 
            this.textTO.Location = new System.Drawing.Point(40, 99);
            this.textTO.Margin = new System.Windows.Forms.Padding(2);
            this.textTO.Name = "textTO";
            this.textTO.Size = new System.Drawing.Size(231, 20);
            this.textTO.TabIndex = 3;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(259, 7);
            this.StudentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(206, 13);
            this.StudentNameLabel.TabIndex = 4;
            this.StudentNameLabel.TabStop = true;
            this.StudentNameLabel.Text = "Use <StudentName> to add student name";
            // 
            // StudentLateTimeLabel
            // 
            this.StudentLateTimeLabel.AutoSize = true;
            this.StudentLateTimeLabel.Location = new System.Drawing.Point(229, 31);
            this.StudentLateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentLateTimeLabel.Name = "StudentLateTimeLabel";
            this.StudentLateTimeLabel.Size = new System.Drawing.Size(259, 13);
            this.StudentLateTimeLabel.TabIndex = 5;
            this.StudentLateTimeLabel.TabStop = true;
            this.StudentLateTimeLabel.Text = "Use <StudentLateTime> to add the time student lated";
            this.StudentLateTimeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudentLateTimeLabel_LinkClicked);
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Location = new System.Drawing.Point(245, 49);
            this.ClassNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(206, 13);
            this.ClassNameLabel.TabIndex = 6;
            this.ClassNameLabel.TabStop = true;
            this.ClassNameLabel.Text = "Use <ClassName> to add your class name";
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.Location = new System.Drawing.Point(269, 71);
            this.TeacherNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(194, 13);
            this.TeacherNameLabel.TabIndex = 7;
            this.TeacherNameLabel.TabStop = true;
            this.TeacherNameLabel.Text = "Use <TeacherName> to add your name";
            // 
            // ExapmleApplier
            // 
            this.ExapmleApplier.Location = new System.Drawing.Point(81, 430);
            this.ExapmleApplier.Margin = new System.Windows.Forms.Padding(2);
            this.ExapmleApplier.Name = "ExapmleApplier";
            this.ExapmleApplier.Size = new System.Drawing.Size(101, 22);
            this.ExapmleApplier.TabIndex = 8;
            this.ExapmleApplier.Text = "Apply Example";
            this.ExapmleApplier.UseVisualStyleBackColor = true;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(186, 430);
            this.ClearAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(101, 22);
            this.ClearAllButton.TabIndex = 9;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Message:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subject:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(328, 99);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(151, 20);
            this.titleText.TabIndex = 13;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(302, 425);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(68, 27);
            this.sendButton.TabIndex = 18;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordText);
            this.groupBox1.Controls.Add(this.userAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 95);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(80, 54);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(120, 20);
            this.passwordText.TabIndex = 21;
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(80, 27);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(120, 20);
            this.userAddress.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email Address";
            // 
            // EmailEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ExapmleApplier);
            this.Controls.Add(this.TeacherNameLabel);
            this.Controls.Add(this.ClassNameLabel);
            this.Controls.Add(this.StudentLateTimeLabel);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.textTO);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmailEditorDialog";
            this.Text = "Email Format Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.TextBox textTO;
        private System.Windows.Forms.LinkLabel StudentNameLabel;
        private System.Windows.Forms.LinkLabel StudentLateTimeLabel;
        private System.Windows.Forms.LinkLabel ClassNameLabel;
        private System.Windows.Forms.LinkLabel TeacherNameLabel;
        private System.Windows.Forms.Button ExapmleApplier;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}