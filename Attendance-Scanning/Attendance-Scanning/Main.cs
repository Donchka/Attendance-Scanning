using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Attendance_Scanning
{
    public partial class Main : Form
    {
        /// <summary>
        /// Ensure that the teacher management window is opened or closed
        /// </summary>
        public bool IsTeacherManagementOpened = false;
        public List<SingleStudent> NotCheckedSingleStudents = new List<SingleStudent>();
        public List<SingleStudent> CheckedSingleStudents = new List<SingleStudent>();

        public Main()
        {
            InitializeComponent();
            TeacherManagementPanel.Hide();
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
        /// <summary>
        /// Set All unchecked students as absent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SetAllUncheckedStudentAsAbsent_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Set all students(even checked) as unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SetAllCheckedStudentsAsUncheck_Click(object sender, EventArgs e)
        {

        }

        private void Button_EditEmailFormat_Click(object sender, EventArgs e)
        {
            EmailEditorDialog EED = new EmailEditorDialog();
            if(EED.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Button_TeacherManagement_Click(object sender, EventArgs e)
        {
            if(IsTeacherManagementOpened)
            {
                TeacherManagementPanel.Hide();
                Button_TeacherManagement.Text = "Show Teacher Management";
                IsTeacherManagementOpened = false;
            }
            else
            {
                TeacherManagementValidater TMV = new TeacherManagementValidater();
                if(TMV.ShowDialog() == DialogResult.OK)
                {
                    TeacherManagementPanel.Show();
                    Button_TeacherManagement.Text = "Hide Teacher Management";
                    IsTeacherManagementOpened = true;
                    TMV.Close();
                }
            }
        }

        private void FileOpener_FileOk(object sender, CancelEventArgs e)
        {
            if(FileOpener.SafeFileName.Split('_')[0].Length != 6)
            {
                MessageBox.Show(FileOpener.SafeFileName.Split('_')[0]);
                MessageBox.Show("Not a valid data file! Please check the file name so it contains the class code!");
                return;
            }
            string[] Data = File.ReadAllLines((FileOpener.FileName));
            MessageBox.Show("Load Complete!");
        }
    }
}
