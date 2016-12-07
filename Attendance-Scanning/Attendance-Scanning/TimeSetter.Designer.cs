namespace Attendance_Scanning
{
    partial class TimeSetter
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
            this.SetTimeButton = new System.Windows.Forms.Button();
            this.NUD_Hrs = new System.Windows.Forms.NumericUpDown();
            this.NUD_Min = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // SetTimeButton
            // 
            this.SetTimeButton.Location = new System.Drawing.Point(8, 134);
            this.SetTimeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SetTimeButton.Name = "SetTimeButton";
            this.SetTimeButton.Size = new System.Drawing.Size(367, 54);
            this.SetTimeButton.TabIndex = 0;
            this.SetTimeButton.Text = "Save";
            this.SetTimeButton.UseVisualStyleBackColor = true;
            this.SetTimeButton.Click += new System.EventHandler(this.SetTimeButton_Click);
            // 
            // NUD_Hrs
            // 
            this.NUD_Hrs.Location = new System.Drawing.Point(55, 64);
            this.NUD_Hrs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NUD_Hrs.Name = "NUD_Hrs";
            this.NUD_Hrs.Size = new System.Drawing.Size(80, 20);
            this.NUD_Hrs.TabIndex = 1;
            // 
            // NUD_Min
            // 
            this.NUD_Min.Location = new System.Drawing.Point(257, 64);
            this.NUD_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NUD_Min.Name = "NUD_Min";
            this.NUD_Min.Size = new System.Drawing.Size(80, 20);
            this.NUD_Min.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time of the period :";
            // 
            // TimeSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_Min);
            this.Controls.Add(this.NUD_Hrs);
            this.Controls.Add(this.SetTimeButton);
            this.Name = "TimeSetter";
            this.Text = "Time Picker";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetTimeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown NUD_Min;
        public System.Windows.Forms.NumericUpDown NUD_Hrs;
    }
}