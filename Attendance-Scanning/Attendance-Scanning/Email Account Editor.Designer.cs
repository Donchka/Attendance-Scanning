namespace Attendance_Scanning
{
    partial class Email_Account_Editor
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.InputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.USNMLabel = new System.Windows.Forms.Label();
            this.PSWDLabel = new System.Windows.Forms.Label();
            this.EmailAddressBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.InputPanel);
            this.MainPanel.Controls.Add(this.ButtonPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(657, 330);
            this.MainPanel.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.OkButton);
            this.ButtonPanel.Controls.Add(this.CancelButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 230);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(657, 100);
            this.ButtonPanel.TabIndex = 0;
            // 
            // InputPanel
            // 
            this.InputPanel.ColumnCount = 2;
            this.InputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.65601F));
            this.InputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.34399F));
            this.InputPanel.Controls.Add(this.USNMLabel, 0, 0);
            this.InputPanel.Controls.Add(this.PSWDLabel, 0, 1);
            this.InputPanel.Controls.Add(this.EmailAddressBox, 1, 0);
            this.InputPanel.Controls.Add(this.PasswordBox, 1, 1);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.RowCount = 2;
            this.InputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputPanel.Size = new System.Drawing.Size(657, 230);
            this.InputPanel.TabIndex = 1;
            // 
            // USNMLabel
            // 
            this.USNMLabel.AutoSize = true;
            this.USNMLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USNMLabel.Location = new System.Drawing.Point(3, 0);
            this.USNMLabel.Name = "USNMLabel";
            this.USNMLabel.Size = new System.Drawing.Size(109, 115);
            this.USNMLabel.TabIndex = 0;
            this.USNMLabel.Text = "User Name:";
            // 
            // PSWDLabel
            // 
            this.PSWDLabel.AutoSize = true;
            this.PSWDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSWDLabel.Location = new System.Drawing.Point(3, 115);
            this.PSWDLabel.Name = "PSWDLabel";
            this.PSWDLabel.Size = new System.Drawing.Size(109, 115);
            this.PSWDLabel.TabIndex = 1;
            this.PSWDLabel.Text = "Password:\r\n";
            // 
            // EmailAddressBox
            // 
            this.EmailAddressBox.Location = new System.Drawing.Point(118, 3);
            this.EmailAddressBox.Name = "EmailAddressBox";
            this.EmailAddressBox.Size = new System.Drawing.Size(536, 28);
            this.EmailAddressBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(118, 118);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(536, 28);
            this.PasswordBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CancelButton.Location = new System.Drawing.Point(0, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 100);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkButton.Location = new System.Drawing.Point(582, 0);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 100);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // Email_Account_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 330);
            this.Controls.Add(this.MainPanel);
            this.Name = "Email_Account_Editor";
            this.Text = "Email Account Editor";
            this.MainPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel InputPanel;
        private System.Windows.Forms.Label USNMLabel;
        private System.Windows.Forms.Label PSWDLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.TextBox EmailAddressBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}