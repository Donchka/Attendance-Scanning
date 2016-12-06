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
    public partial class Email_Account_Editor : Form
    {
        Data_Processor DP;
        public Email_Account_Editor(Data_Processor DPO)
        {
            DP = DPO;
            InitializeComponent();
            EmailAddressBox.Text = Properties.Settings.Default.EmailAddress;
            PasswordBox.Text = DP.PasswordDecryptor(Properties.Settings.Default.EmailPosswordEncrypted,12);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(!EmailAddressBox.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Not a valid Gmail Bot! Please check again!");
            }
            else if (PasswordBox.Text.Length == 0)
            {
                MessageBox.Show("Not a valid password! Please check again!");
            }
            else
            {
                Properties.Settings.Default.EmailAddress = EmailAddressBox.Text.Trim();
                Properties.Settings.Default.EmailPosswordEncrypted = DP.PasswordEncryptor(PasswordBox.Text, 12);
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
