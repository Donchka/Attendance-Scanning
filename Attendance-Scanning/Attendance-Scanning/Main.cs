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
using System.Net;
using System.Net.Mail;

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
            Course_Code_Selector_Dialog CCSD = new Course_Code_Selector_Dialog();
            if(CCSD.ShowDialog() == DialogResult.OK)
            {

            }
        }

        NetworkCredential userLogin;
        SmtpClient smtpc;
        MailMessage mail;

        private void button2_Click(object sender, EventArgs e)
        {
            userLogin = new NetworkCredential(userAddress.Text, passwordText.Text);//user's email address and password
            smtpc = new SmtpClient("smtp.gmail.com");
            smtpc.Port = 587;//normal port 
            smtpc.Credentials = userLogin;//apply user's info
            mail = new MailMessage { From = new MailAddress(userAddress.Text, "CKSSmailer", Encoding.UTF8) };//get sending address
            mail.To.Add(new MailAddress(textTO.Text));//get receving address
            mail.Subject = titleText.Text;//get title 
            mail.Body = MessageText.Text;//get message body
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            smtpc.EnableSsl = true;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            smtpc.SendCompleted += new SendCompletedEventHandler(notification);
            string status = "Sending...";
            smtpc.SendAsync(mail, status);//send the message
        }


        private static void notification(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("send cancelled");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else
            {
                MessageBox.Show("Message sent.");
            }
        }

        private void Button_EditEmailAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
