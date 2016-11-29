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
    public partial class SendMailSelector : Form
    {
        public SendMailSelector()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
