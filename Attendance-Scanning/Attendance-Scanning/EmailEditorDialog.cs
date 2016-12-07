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
    public partial class EmailEditorDialog : Form
    {
        public EmailEditorDialog()
        {
            InitializeComponent();
            正文.Text = Properties.Settings.Default.EmailFormatMain;
            TitleTextBox.Text = Properties.Settings.Default.EmailFormatTitle;
        }

        private void StudentNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            正文.AppendText("<StudentName>");
        }

        private void StudentLateTimeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            正文.AppendText("<StudentLateTime>");
        }

        private void ClassNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            正文.AppendText("<ClassCode>");
        }

        private void TeacherNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            正文.AppendText("<TeacherName>");
        }
        /// <summary>
        /// By clicking this, clear the title and main body paragraph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            正文.Clear();
            TitleTextBox.Clear();
        }
        /// <summary>
        /// Apply an example mail to help teachers make their own solution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExapmleApplier_Click(object sender, EventArgs e)
        {
            正文.Text = "Hello! \r\n This is from <ClassCode>, your child <StudentName> was not here today. Please check your child's status. Thank you!";
            TitleTextBox.Text = "Absent Alarm";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EmailFormatMain = 正文.Text;
            Properties.Settings.Default.EmailFormatTitle = TitleTextBox.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
