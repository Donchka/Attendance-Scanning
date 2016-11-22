using System;
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
        public Data_Processor DP;
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
            String TemperalPasswordDecryptor = "";
            TemperalPasswordDecryptor = DP.PasswordDecryptor(Properties.Settings.Default.TeacherPasswordencrypted, 13);
            if(PasswordBox.Text == TemperalPasswordDecryptor)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                TemperalPasswordDecryptor = "Safauawjefuehfhdsugbauwefuefiaeufbiaewbuifbaewuifbuawefewafergaergwg";
                MessageBox.Show("Incorrect Password!");
            }
        }
    }
}
