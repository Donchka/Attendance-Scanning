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
                List<string> Temp = new List<string>();
                Temp.Add(DT.Year + " " + DT.Month + " " + DT.Day);
                Temp.Add(SSS.Split(',')[3]);
                DateAndNoteListView.Items.Add(new ListViewItem(Temp.ToArray()));
                DTList.Add(DT);
            }
        }

        private void B_Nothing_Click(object sender, EventArgs e)
        {
            foreach(DateTime DTtttt in DTList)
            {
                if (DTtttt == DateTimePicker.Value)
                {

                }
            }
        }
    }
}
