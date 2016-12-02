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
    public partial class PasswordEditor : Form
    {
        Data_Processor DP;
        public PasswordEditor(Data_Processor DDP)
        {
            DP = DDP;
            InitializeComponent();
            DialogResult = DialogResult.None;
        }
        /// <summary>
        /// Ensure the password is correct, then write it into the setting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_Button_Click(object sender, EventArgs e)
        {
            if(OldBox.Text != DP.PasswordDecryptor(Properties.Settings.Default.TeacherPasswordencrypted,13))
            {
                MessageBox.Show("Wrong old password!");
                return;
            }
            else if (NewBox.Text != ReenterBox.Text ){
                MessageBox.Show("Different new passwords!");
                return;
            }
            else
            {
                Properties.Settings.Default.TeacherPasswordencrypted = DP.PasswordEncryptor(ReenterBox.Text, 13);
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
