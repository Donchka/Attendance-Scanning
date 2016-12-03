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
    public partial class 毒瘤之SpecialDaysEditor : Form
    {
        public List<DateTime> DTList = new List<DateTime>();
        public Data_Processor DPPPPPP;
        public 毒瘤之SpecialDaysEditor(Data_Processor DPPP)
        {
            InitializeComponent();
            DPPPPPP = DPPP;
            foreach (string SSS in Properties.Settings.Default.SpecialDateSetting)
            {
                DateTime DT = DPPP.FromStringToDateTime(SSS);
                List<string> Temp = new List<string>();
                Temp.Add(DPPP.FromDateTimeToString(DT));
                Temp.Add(SSS.Split('-')[3]);
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
                    foreach (ListViewItem LVI in DateAndNoteListView.Items)
                    {
                        if (LVI.SubItems[0].ToString().Contains(DPPPPPP.FromDateTimeToString(DTtttt)))
                        {
                            DateAndNoteListView.Items.Remove(LVI);
                            ///int xxx = DTList.
                            ///DTList.
                        }
                    }
                }
            }
        }
    }
}
