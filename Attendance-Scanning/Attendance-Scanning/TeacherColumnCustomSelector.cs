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
    public partial class TeacherColumnCustomSelector : Form
    {
        public TeacherColumnCustomSelector(string[] SeperatedColumnDatas, int DefaultFirst, int DefaultLast, int DefaultEmail, int DefaultNum)
        {
            InitializeComponent();
            EmailComboBox.Items.AddRange(SeperatedColumnDatas);
            EmailComboBox.SelectedIndex = DefaultEmail;
            FirstNameComboBox.Items.AddRange(SeperatedColumnDatas);
            FirstNameComboBox.SelectedIndex = DefaultFirst;
            LastNameComboBox.Items.AddRange(SeperatedColumnDatas);
            LastNameComboBox.SelectedIndex = DefaultLast;
            StudentNumberComboBox.Items.AddRange(SeperatedColumnDatas);
            StudentNumberComboBox.SelectedIndex = DefaultNum;
        }
    }
}
