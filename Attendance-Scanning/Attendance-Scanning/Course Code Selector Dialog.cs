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
    public partial class Course_Code_Selector_Dialog : Form
    {
        public Course_Code_Selector_Dialog()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            ///Ensure that it is a course code
            if(CourseCodeComboBox.Text.Length == 6)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
