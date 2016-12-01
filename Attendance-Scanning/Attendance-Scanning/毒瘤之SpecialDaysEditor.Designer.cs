namespace Attendance_Scanning
{
    partial class 毒瘤之SpecialDaysEditor
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateAndNoteListView = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_Nothing = new System.Windows.Forms.Button();
            this.B_NoClass = new System.Windows.Forms.Button();
            this.B_SuperSpecial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(162, 5);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(384, 28);
            this.DateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set this date: ";
            // 
            // DateAndNoteListView
            // 
            this.DateAndNoteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Note});
            this.DateAndNoteListView.Location = new System.Drawing.Point(12, 102);
            this.DateAndNoteListView.Name = "DateAndNoteListView";
            this.DateAndNoteListView.Size = new System.Drawing.Size(534, 259);
            this.DateAndNoteListView.TabIndex = 2;
            this.DateAndNoteListView.UseCompatibleStateImageBehavior = false;
            this.DateAndNoteListView.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date:";
            this.Date.Width = 378;
            // 
            // Note
            // 
            this.Note.Text = "Note";
            this.Note.Width = 120;
            // 
            // B_Nothing
            // 
            this.B_Nothing.Location = new System.Drawing.Point(16, 39);
            this.B_Nothing.Name = "B_Nothing";
            this.B_Nothing.Size = new System.Drawing.Size(122, 47);
            this.B_Nothing.TabIndex = 3;
            this.B_Nothing.Text = "Not Special";
            this.B_Nothing.UseVisualStyleBackColor = true;
            this.B_Nothing.Click += new System.EventHandler(this.B_Nothing_Click);
            // 
            // B_NoClass
            // 
            this.B_NoClass.Location = new System.Drawing.Point(197, 39);
            this.B_NoClass.Name = "B_NoClass";
            this.B_NoClass.Size = new System.Drawing.Size(122, 47);
            this.B_NoClass.TabIndex = 4;
            this.B_NoClass.Text = "No Class";
            this.B_NoClass.UseVisualStyleBackColor = true;
            // 
            // B_SuperSpecial
            // 
            this.B_SuperSpecial.Location = new System.Drawing.Point(351, 39);
            this.B_SuperSpecial.Name = "B_SuperSpecial";
            this.B_SuperSpecial.Size = new System.Drawing.Size(195, 47);
            this.B_SuperSpecial.TabIndex = 5;
            this.B_SuperSpecial.Text = "Special Period Time";
            this.B_SuperSpecial.UseVisualStyleBackColor = true;
            // 
            // SpecialDaysEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 373);
            this.Controls.Add(this.B_SuperSpecial);
            this.Controls.Add(this.B_NoClass);
            this.Controls.Add(this.B_Nothing);
            this.Controls.Add(this.DateAndNoteListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "SpecialDaysEditor";
            this.Text = "SpecialDaysEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView DateAndNoteListView;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.Button B_Nothing;
        private System.Windows.Forms.Button B_NoClass;
        private System.Windows.Forms.Button B_SuperSpecial;
    }
}