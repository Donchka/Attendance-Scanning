namespace Attendance_Scanning
{
    partial class TeacherColumnCustomSelector
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstNameComboBox = new System.Windows.Forms.ComboBox();
            this.LastNameComboBox = new System.Windows.Forms.ComboBox();
            this.EmailComboBox = new System.Windows.Forms.ComboBox();
            this.StudentNumberComboBox = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.Ignore = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.07908F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.92092F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameComboBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LastNameComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EmailComboBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.StudentNumberComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.OK, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ignore, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 144);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guaradian Emails";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(985, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Number";
            // 
            // FirstNameComboBox
            // 
            this.FirstNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstNameComboBox.FormattingEnabled = true;
            this.FirstNameComboBox.Location = new System.Drawing.Point(3, 75);
            this.FirstNameComboBox.Name = "FirstNameComboBox";
            this.FirstNameComboBox.Size = new System.Drawing.Size(185, 26);
            this.FirstNameComboBox.TabIndex = 4;
            // 
            // LastNameComboBox
            // 
            this.LastNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LastNameComboBox.FormattingEnabled = true;
            this.LastNameComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LastNameComboBox.Location = new System.Drawing.Point(194, 75);
            this.LastNameComboBox.Name = "LastNameComboBox";
            this.LastNameComboBox.Size = new System.Drawing.Size(334, 26);
            this.LastNameComboBox.TabIndex = 5;
            // 
            // EmailComboBox
            // 
            this.EmailComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmailComboBox.FormattingEnabled = true;
            this.EmailComboBox.Location = new System.Drawing.Point(534, 75);
            this.EmailComboBox.Name = "EmailComboBox";
            this.EmailComboBox.Size = new System.Drawing.Size(444, 26);
            this.EmailComboBox.TabIndex = 6;
            // 
            // StudentNumberComboBox
            // 
            this.StudentNumberComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentNumberComboBox.FormattingEnabled = true;
            this.StudentNumberComboBox.Location = new System.Drawing.Point(984, 75);
            this.StudentNumberComboBox.Name = "StudentNumberComboBox";
            this.StudentNumberComboBox.Size = new System.Drawing.Size(278, 26);
            this.StudentNumberComboBox.TabIndex = 7;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK.Location = new System.Drawing.Point(1269, 4);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(81, 64);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Ignore
            // 
            this.Ignore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Ignore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ignore.Location = new System.Drawing.Point(1268, 75);
            this.Ignore.Name = "Ignore";
            this.Ignore.Size = new System.Drawing.Size(83, 66);
            this.Ignore.TabIndex = 9;
            this.Ignore.Text = "Ignore this student";
            this.Ignore.UseVisualStyleBackColor = true;
            // 
            // TeacherColumnCustomSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 144);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TeacherColumnCustomSelector";
            this.Text = "I don\'t know the real information of this student, please manually set them!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Ignore;
        public System.Windows.Forms.ComboBox FirstNameComboBox;
        public System.Windows.Forms.ComboBox LastNameComboBox;
        public System.Windows.Forms.ComboBox EmailComboBox;
        public System.Windows.Forms.ComboBox StudentNumberComboBox;
    }
}