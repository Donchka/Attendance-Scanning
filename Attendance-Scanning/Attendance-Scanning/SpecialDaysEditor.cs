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
    public partial class SpecialDaysEditor : Form
    {
        public List<DateTime> DTList = new List<DateTime>();
        public SpecialDaysEditor()
        {
            InitializeComponent();
            foreach (string SSS in Properties.Settings.Default.SpecialDateSetting)
            {
                DateTime DT = new DateTime(int.Parse(SSS.Split(',')[0]), int.Parse(SSS.Split(',')[1]), int.Parse(SSS.Split(',')[2]));
                DateAndNoteListView.Items.Add(new ListViewItem(""));
            }
        }
    }
}
