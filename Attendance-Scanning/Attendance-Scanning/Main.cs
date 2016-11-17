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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicked the button's reaction is Load a File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFileButtonClicked(object sender, EventArgs e)
        {
            FileOpener.ShowDialog();
        }
        /// <summary>
        /// Save thy file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSaverButtonClicked(object sender, EventArgs e)
        {
            FileSaver.ShowDialog();
        }

        private void Button_SetAbsent_Click(object sender, EventArgs e)
        {

        }
    }
}
