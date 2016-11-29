namespace Attendance_Scanning
{
    partial class Course_Code_Selector_Dialog
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
            this.CourseCode_Label = new System.Windows.Forms.Label();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseCode_Label
            // 
            this.CourseCode_Label.AutoSize = true;
            this.CourseCode_Label.Location = new System.Drawing.Point(12, 21);
            this.CourseCode_Label.Name = "CourseCode_Label";
            this.CourseCode_Label.Size = new System.Drawing.Size(125, 18);
            this.CourseCode_Label.TabIndex = 0;
            this.CourseCode_Label.Text = "Course Code: ";
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Location = new System.Drawing.Point(145, 13);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(121, 26);
            this.CourseCodeComboBox.TabIndex = 1;
            this.CourseCodeComboBox.TabStop = false;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(12, 77);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(254, 44);
            this.OK_Button.TabIndex = 2;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Course_Code_Selector_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 123);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.CourseCodeComboBox);
            this.Controls.Add(this.CourseCode_Label);
            this.Name = "Course_Code_Selector_Dialog";
            this.Text = "Course Code?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseCode_Label;
        private System.Windows.Forms.Button OK_Button;
        public System.Windows.Forms.ComboBox CourseCodeComboBox;
    }
}