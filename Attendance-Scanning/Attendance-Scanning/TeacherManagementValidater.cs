﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Scanning
{
    public partial class TeacherManagementValidater : Form
    {
        public Main theMain;
        public TeacherManagementValidater()
        {
            InitializeComponent();
            Cancel_Button.DialogResult = DialogResult.Cancel;
            PasswordBox.TextChanged += PasswordBox_TextChanged; ;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if(PasswordBox.Text.Contains("\r\n") || PasswordBox.Text.Contains("\r") || PasswordBox.Text.Contains("\n"))
            {
                Enter_Button_Click(new object(), new EventArgs());
            }
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            if(PasswordBox.Text == theMain.PassWord)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
        }
    }
}
