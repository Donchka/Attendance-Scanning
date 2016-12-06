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
    public partial class TimeSetter : Form
    {
        public TimeSetter(bool TimeLimit)
        {
            InitializeComponent();
            if(TimeLimit)
            {
                SetTimeButton.Text = "Set this as the start of late counting";
            }
            else
            {
                SetTimeButton.Text = "Set this as the point of starting counting \" Late\"";
            }
        }

        private void SetTimeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
