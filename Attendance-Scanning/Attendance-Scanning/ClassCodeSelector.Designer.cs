namespace Attendance_Scanning
{
    partial class ClassCodeSelector
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
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.LAAbe = new System.Windows.Forms.Label();
            this.ClassCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Yes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.No, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LAAbe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClassCodeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ColumnComboBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Yes
            // 
            this.Yes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Yes.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Yes.Location = new System.Drawing.Point(3, 70);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(277, 61);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.No.Location = new System.Drawing.Point(286, 70);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(277, 61);
            this.No.TabIndex = 1;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            // 
            // LAAbe
            // 
            this.LAAbe.AutoSize = true;
            this.LAAbe.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LAAbe.Location = new System.Drawing.Point(3, 0);
            this.LAAbe.Name = "LAAbe";
            this.LAAbe.Size = new System.Drawing.Size(244, 56);
            this.LAAbe.TabIndex = 2;
            this.LAAbe.Text = "Please type in or select your class code:\r\n";
            this.LAAbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassCodeComboBox
            // 
            this.ClassCodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ClassCodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClassCodeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassCodeComboBox.FormattingEnabled = true;
            this.ClassCodeComboBox.Location = new System.Drawing.Point(286, 3);
            this.ClassCodeComboBox.Name = "ClassCodeComboBox";
            this.ClassCodeComboBox.Size = new System.Drawing.Size(277, 26);
            this.ClassCodeComboBox.TabIndex = 3;
            this.ClassCodeComboBox.TextChanged += new System.EventHandler(this.ClassCodeComboBox_TextChanged);
            this.ClassCodeComboBox.Enter += new System.EventHandler(this.ClassCodeComboBox_GotFocus);
            this.ClassCodeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClassCodeComboBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cannot find your class code?\r\nPlease select the right Column for codes.\r\n";
            // 
            // ColumnComboBox
            // 
            this.ColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnComboBox.FormattingEnabled = true;
            this.ColumnComboBox.Location = new System.Drawing.Point(287, 138);
            this.ColumnComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColumnComboBox.Name = "ColumnComboBox";
            this.ColumnComboBox.Size = new System.Drawing.Size(272, 26);
            this.ColumnComboBox.TabIndex = 5;
            this.ColumnComboBox.SelectedIndexChanged += new System.EventHandler(this.ColumnComboBox_SelectedIndexChanged);
            // 
            // ClassCodeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 205);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClassCodeSelector";
            this.Text = "ClassCodeSelector";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Label LAAbe;
        public System.Windows.Forms.ComboBox ClassCodeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ColumnComboBox;
    }
}