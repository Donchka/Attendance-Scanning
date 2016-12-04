﻿using System;
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
using UnityEngine;

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
        public TimeKeeper tk = new TimeKeeper();
        public Data_Processor DP;
        public DateTime CustomTimmmmmmmmmmmmmmmmmmmmme = new DateTime();
        public string classCode = "";
        public bool LoadedStudentDataaaaa = false;
        public bool Saved = true;

        public Main()
        {
            DP = new Data_Processor(tk);
            InitializeComponent();
            TeacherManagementPanel.Hide();
            StudentListPanel.Hide();
            BarCodeInputLabel.Hide();
            this.Size = new Size(this.Width,80);
        }

        /// <summary>
        /// Clicked the button's reaction is Load a File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFileButtonClicked(object sender, EventArgs e)
        {
            if (LoadedStudentDataaaaa)///Ensure that this opreation is not by students.
            {
                if (new TeacherManagementValidater(DP).ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
            FileOpener.ShowDialog();
            CustomTimmmmmmmmmmmmmmmmmmmmme = new DateTime();
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
            foreach (ListViewItem LVI in ListView_Uncheck.Items)
            {
                LVI.Font = new System.Drawing.Font(LVI.Font, System.Drawing.FontStyle.Strikeout);
            }
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
            if (EED.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Button_TeacherManagement_Click(object sender, EventArgs e)
        {
            if (IsTeacherManagementOpened)
            {
                TeacherManagementPanel.Hide();
                Button_TeacherManagement.Text = "Show Teacher Management";
                IsTeacherManagementOpened = false;
            }
            else
            {
                TeacherManagementValidater TMV = new TeacherManagementValidater(DP);
                if (TMV.ShowDialog() == DialogResult.OK)
                {
                    TeacherManagementPanel.Show();
                    TimeEditing.Visible = true;
                    PersonalData.Visible = true;
                    Button_TeacherManagement.Text = "Hide Teacher Management";
                    IsTeacherManagementOpened = true;
                    TMV.Close();
                }
            }
        }

        private void FileOpener_FileOk(object sender, CancelEventArgs e)
        {
            string ClassCodeTempelate;
            if(!Saved)
            {
                DialogResult DR = MessageBox.Show("You did not save the attendance data! would you like to save it now?", "Not saved!", MessageBoxButtons.YesNoCancel);
                //If yes, create new one; if no, go on; if cancel, return.
                if (DR == DialogResult.Yes)
                {
                    SaveData_Click(new object(), new EventArgs());
                }
                else if (DR == DialogResult.Cancel)
                {
                    return;
                }
            }
            string[] Data = File.ReadAllLines((FileOpener.FileName));
            if (FileOpener.SafeFileName.Split('_')[0].Length != 6)
            {
                DialogResult DR = MessageBox.Show("Cannot be identified as a single class file! Would you like to create a new single class file from this one?", "Loading New File", MessageBoxButtons.YesNoCancel);
                //If yes, create new one; if no, go on; if cancel, return.
                if (DR == DialogResult.Yes)
                {
                    ClassCodeSelector CCS = new ClassCodeSelector(Data);
                    if (CCS.ShowDialog() == DialogResult.OK)
                    {
                        ///File name as class code is nintialized by DP.initialize thingy
                        ///open that file 
                        ///return;
                    }
                }
                else if(DR == DialogResult.Cancel)
                {
                    return;
                }
                
            }
            ListView_Uncheck.ShowGroups = true;
            //ListView_Uncheck.
            NotCheckedSingleStudents.Clear();
            CheckedSingleStudents.Clear();
            foreach (SingleStudent SS in DP.CSVCovertor(Data))
            {

                //ListView_Uncheck.Items.Add(SS.LastName + " " + SS.FirstName);
                NotCheckedSingleStudents.Add(SS);
                List<String> Meow = new List<string>();
                Meow.Add(SS.LastName);
                Meow.Add(SS.FirstName);
                Meow.Add(SS.Index);
                ListView_Uncheck.Items.Add(new ListViewItem(Meow.ToArray()));
                ListView_Uncheck.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            Label_Current_File.Text = "Current File: " + FileOpener.SafeFileName;
            StudentListPanel.Show();
            BarCodeInputLabel.Show();
            this.Size = new Size(820, 574);
            LoadedStudentDataaaaa = true;
            Saved = false;
            Box_StudentIndex.Focus();

            //Course_Code_Selector_Dialog CCSD = new Course_Code_Selector_Dialog();
            //if(CCSD.ShowDialog() == DialogResult.OK)
            //{

            //}
        }

        NetworkCredential userLogin;
        SmtpClient smtpc;
        MailMessage mail;

        private void SendMailButtonClick(object sender, EventArgs e)
        {
            SendMailSelector SMS = new SendMailSelector();
            if (SMS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool ToAbsent = SMS.Absent_Student_Checkbox.Checked;
                bool ToLate = SMS.Late_Students_Checkbox.Checked;
                bool ToUnc = SMS.Unchecked_Students_Checkbox.Checked;
                foreach (ListViewItem LVI in ListView_Uncheck.Items)
                {
                    foreach (SingleStudent SS in NotCheckedSingleStudents)
                    {
                        if (SS.IsMe(LVI.SubItems[2].ToString()))
                        {
                            //MessageBox.Show(DP.MailReplacer(DateTime.Now, tk.perform(DateTime.Now, SS, CustomTimmmmmmmmmmmmmmmmmmmmme), SS, Properties.Settings.Default.EmailFormatTitle));
                            //MessageBox.Show(DP.MailReplacer(DateTime.Now, tk.perform(DateTime.Now, SS, CustomTimmmmmmmmmmmmmmmmmmmmme), SS, Properties.Settings.Default.EmailFormatMain));
                            MailSender(SS, DateTime.Now, tk.perform(DateTime.Now, SS, CustomTimmmmmmmmmmmmmmmmmmmmme));
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Send a mail to a specific student with late data
        /// </summary>
        /// <param name="Student">A SingleStudent Instance</param>
        /// <param name="time">Time now</param>
        /// <param name="LateData">Late Data</param>
        public void MailSender(SingleStudent Student, DateTime time, String LateData)
        {
            userLogin = new NetworkCredential(Properties.Settings.Default.EmailAddress, DP.PasswordDecryptor(Properties.Settings.Default.EmailPosswordEncrypted, 13));//user's email address and password
            smtpc = new SmtpClient("smtp.gmail.com");
            smtpc.Port = 587;//normal port 
            smtpc.Credentials = userLogin;//apply user's info
            mail = new MailMessage { From = new MailAddress(Properties.Settings.Default.EmailAddress, "CKSSmailer", Encoding.UTF8) };//get sending address
            mail.To.Add(new MailAddress(Student.EmailAddress));//get receving address
            mail.Subject = DP.MailReplacer(time, LateData, Student, Properties.Settings.Default.EmailFormatTitle);//get title 
            mail.Body = DP.MailReplacer(time, LateData, Student, Properties.Settings.Default.EmailFormatMain);//get message body
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
                MessageBox.Show("Sending progress cancelled");
            }
            else if (e.Error != null)
            {
                if (e.Error.ToString().Contains("secure"))
                {
                    MessageBox.Show("Your account may not have Less Secure App Access enabled, see google setting to turn on that.:)\n OR\n Your login info is invalid,check it out!");
                }
                else
                {
                    MessageBox.Show(e.Error.ToString());
                }
            }
            else
            {
                MessageBox.Show("Message sent.");
            }
        }

        private void Button_EditEmailAccount_Click(object sender, EventArgs e)
        {
            Email_Account_Editor ema = new Email_Account_Editor();
            ema.Show();
        }

        private void button_CallPasswordEditor_Click(object sender, EventArgs e)
        {
            PasswordEditor PWE = new PasswordEditor(DP);
            if (PWE.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Done!");
                PWE.Close();
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            foreach (SingleStudent stu in NotCheckedSingleStudents)
            {
                if (stu.IsMe(Box_StudentIndex.Text))
                {
                    foreach (object OBJ in ListView_Uncheck.Items)
                    {
                        if (OBJ.ToString().Contains(stu.LastName))
                        {
                            List<String> Meow = new List<string>();
                            stu.AttandanceTime = DateTime.Now;
                            Meow.Add(stu.LastName);
                            Meow.Add(stu.FirstName);
                            Meow.Add(stu.Index);
                            Meow.Add(tk.perform(DateTime.Now, stu, CustomTimmmmmmmmmmmmmmmmmmmmme));
                            
                            //Meow.Add(DateTime.Now.TimeOfDay.ToString("00:00"));
                            CheckedListView.Items.Add(new ListViewItem(Meow.ToArray()));
                            CheckedSingleStudents.Add(stu);
                            NotCheckedSingleStudents.Remove(stu);
                            ListView_Uncheck.Items.Remove((ListViewItem)OBJ);
                            Box_StudentIndex.Text = "";
                            return;
                        }
                    }
                }
            }
        }

        private void Button_SetTime_Click(object sender, EventArgs e)
        {
            int hhh;
            int mmm;
            DateTime DTNOW = DateTime.Now;
            if (int.TryParse(StartHour.Text, out hhh) && int.TryParse(StartMinute.Text, out mmm)) {
                CustomTimmmmmmmmmmmmmmmmmmmmme = new DateTime(DTNOW.Year, DTNOW.Month, DTNOW.Day, hhh, mmm,0);
           }

        }

        private void Box_StudentIndex_TextChanged(object sender, EventArgs e)
        {
            Check_Click(new object(), new EventArgs());
        }

        private void editTimeLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSetter tl = new TimeSetter(true);
            tl.Show();
        }
        /// <summary>
        /// If user pressed Enter, see it as Check_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_StudentIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(KeyCode.Return) || e.KeyCode.Equals(KeyCode.KeypadEnter))
            {
                Check_Click(new object(), new EventArgs());
            }
        }
        /// <summary>
        /// User start save their file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveData_Click(object sender, EventArgs e)
        {
            FileSaver.FileName = classCode +".csv";
            FileSaver.ShowDialog();
        }
        /// <summary>
        /// On saving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSaving(object sender, CancelEventArgs e)
        {

        }
    }
}
