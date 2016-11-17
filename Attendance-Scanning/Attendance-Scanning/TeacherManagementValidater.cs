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
        public TeacherManagementValidater()
        {
            InitializeComponent();
            Enter_Button.DialogResult = DialogResult.OK;
            CancelButton.DialogResult = DialogResult.Cancel;
        }
    }
}
