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
            this.正文 = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameLabel = new System.Windows.Forms.LinkLabel();
            this.StudentLateTimeLabel = new System.Windows.Forms.LinkLabel();
            this.ClassNameLabel = new System.Windows.Forms.LinkLabel();
            this.TeacherNameLabel = new System.Windows.Forms.LinkLabel();
            this.ExapmleApplier = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.SelectionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SelectionPanel.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(581, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(136, 37);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save Format";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(6, 9);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(124, 42);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // 正文
            // 
            this.正文.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.正文.Location = new System.Drawing.Point(0, -179);
            this.正文.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.正文.Multiline = true;
            this.正文.Name = "正文";
            this.正文.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.正文.Size = new System.Drawing.Size(710, 562);
            this.正文.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleTextBox.Location = new System.Drawing.Point(0, 0);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(710, 28);
            this.TitleTextBox.TabIndex = 3;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(3, 0);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(341, 18);
            this.StudentNameLabel.TabIndex = 4;
            this.StudentNameLabel.TabStop = true;
            this.StudentNameLabel.Text = "Use <StudentName> to add student name";
            this.StudentNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudentNameLabel_LinkClicked);
            // 
            // StudentLateTimeLabel
            // 
            this.StudentLateTimeLabel.AutoSize = true;
            this.StudentLateTimeLabel.Location = new System.Drawing.Point(3, 45);
            this.StudentLateTimeLabel.Name = "StudentLateTimeLabel";
            this.StudentLateTimeLabel.Size = new System.Drawing.Size(467, 18);
            this.StudentLateTimeLabel.TabIndex = 5;
            this.StudentLateTimeLabel.TabStop = true;
            this.StudentLateTimeLabel.Text = "Use <StudentLateTime> to add the time student lated";
            this.StudentLateTimeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudentLateTimeLabel_LinkClicked);
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Location = new System.Drawing.Point(3, 95);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(350, 18);
            this.ClassNameLabel.TabIndex = 6;
            this.ClassNameLabel.TabStop = true;
            this.ClassNameLabel.Text = "Use <ClassName> to add your class name";
            this.ClassNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClassNameLabel_LinkClicked);
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.Location = new System.Drawing.Point(3, 145);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(314, 18);
            this.TeacherNameLabel.TabIndex = 7;
            this.TeacherNameLabel.TabStop = true;
            this.TeacherNameLabel.Text = "Use <TeacherName> to add your name";
            this.TeacherNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TeacherNameLabel_LinkClicked);
            // 
            // ExapmleApplier
            // 
            this.ExapmleApplier.Location = new System.Drawing.Point(165, 15);
            this.ExapmleApplier.Name = "ExapmleApplier";
            this.ExapmleApplier.Size = new System.Drawing.Size(152, 30);
            this.ExapmleApplier.TabIndex = 8;
            this.ExapmleApplier.Text = "Apply Example";
            this.ExapmleApplier.UseVisualStyleBackColor = true;
            this.ExapmleApplier.Click += new System.EventHandler(this.ExapmleApplier_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(390, 15);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(152, 30);
            this.ClearAllButton.TabIndex = 9;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.ColumnCount = 1;
            this.SelectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectionPanel.Controls.Add(this.StudentNameLabel, 0, 0);
            this.SelectionPanel.Controls.Add(this.StudentLateTimeLabel, 0, 1);
            this.SelectionPanel.Controls.Add(this.ClassNameLabel, 0, 2);
            this.SelectionPanel.Controls.Add(this.TeacherNameLabel, 0, 3);
            this.SelectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.SelectionPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.RowCount = 4;
            this.SelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.22222F));
            this.SelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.77778F));
            this.SelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SelectionPanel.Size = new System.Drawing.Size(729, 181);
            this.SelectionPanel.TabIndex = 10;
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.TitleTextBox);
            this.TextPanel.Controls.Add(this.正文);
            this.TextPanel.Location = new System.Drawing.Point(6, 189);
            this.TextPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(710, 383);
            this.TextPanel.TabIndex = 11;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.Cancel);
            this.ButtonPanel.Controls.Add(this.ExapmleApplier);
            this.ButtonPanel.Controls.Add(this.Save);
            this.ButtonPanel.Controls.Add(this.ClearAllButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 579);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(729, 54);
            this.ButtonPanel.TabIndex = 12;
            // 
            // EmailEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 633);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.SelectionPanel);
            this.Name = "EmailEditorDialog";
            this.Text = "Email Format Editor";
            this.SelectionPanel.ResumeLayout(false);
            this.SelectionPanel.PerformLayout();
            this.TextPanel.ResumeLayout(false);
            this.TextPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox 正文;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.LinkLabel StudentNameLabel;
        private System.Windows.Forms.LinkLabel StudentLateTimeLabel;
        private System.Windows.Forms.LinkLabel ClassNameLabel;
        private System.Windows.Forms.LinkLabel TeacherNameLabel;
        private System.Windows.Forms.Button ExapmleApplier;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.TableLayoutPanel SelectionPanel;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Panel ButtonPanel;
    }
}