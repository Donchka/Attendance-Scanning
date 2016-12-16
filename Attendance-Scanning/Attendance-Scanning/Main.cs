using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
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
        public DateTime CustomLateStartPoint = new DateTime();
        public string classCode = "";
        public bool LoadedStudentDataaaaa = false;
        public bool Saved = true;
        public string ShouldBeTheFileName = "";

        public Main()
        {
            DP = new Data_Processor(tk);
            InitializeComponent();
            TeacherManagementPanel.Hide();
            StudentListPanel.Hide();
            BarCodeInputLabel.Hide();
            Button_Save.Visible = false;
            FileOpener.FileName = Properties.Settings.Default.ClassCode + "_ClassFile.csv";
            this.Size = new Size(this.Width, 80);
        }

        /// <summary>
        /// Clicked the button's reaction is Load a File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFileButtonClicked(object sender, EventArgs e)
        {
            tk.updateTime(new DateTime());
            tk.reminder(DateTime.Now);
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

        private void FileOpener_FileOk(object sender, CancelEventArgs e)
        {
            string ClassCodeTempelate = "";
            if (!Saved)
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

            string[] Data;

            try
            {
                Data = File.ReadAllLines((FileOpener.FileName));
            }
            catch
            {
                MessageBox.Show("Cannot Open a File while it has been opened by another program!");
                return;
            }
            if (FileOpener.SafeFileName.Split('_')[0].Length != 9 && FileOpener.SafeFileName.Split('_')[0].Length != 8)
            {
                DialogResult DR = MessageBox.Show("Cannot be identified as a single class file! Would you like to create a new single class file from this one? \r\nPlease note that you CAN STILL load this one if it was created by me!\r\n\r\nClick Yes: Create a new class file from this file. You will need to select your class code. \r\nClick No: Load this file as a single class file.  \r\nClick Cancel: Stop this opretion and load a new file \r\n\r\nclass file: A single file that contains all students in one class with their daily attendance records.", "Loading New File", MessageBoxButtons.YesNoCancel);
                //If yes, create new one; if no, go on; if cancel, return.
                if (DR == DialogResult.Yes)
                {
                    ClassCodeSelector CCS = new ClassCodeSelector(Data,DP);
                    if (CCS.ShowDialog() == DialogResult.OK)
                    {
                        ClassCodeTempelate = CCS.ClassCodeComboBox.Text;
                        DP.InitializeTheCSVFile(CCS.stustu, ClassCodeTempelate, FileOpener.FileName.Remove(FileOpener.FileName.Length - FileOpener.SafeFileName.Length - 1, FileOpener.SafeFileName.Length) + ClassCodeTempelate + "_ClassFile.csv");
                        Data = File.ReadAllLines(FileOpener.FileName.Remove(FileOpener.FileName.Length - FileOpener.SafeFileName.Length - 1, FileOpener.SafeFileName.Length) + ClassCodeTempelate + "_ClassFile.csv");
                        ShouldBeTheFileName = ClassCodeTempelate + "_ClassFile.csv";
                    }
                    else
                    {
                        return;
                    }
                }
                else if (DR == DialogResult.Cancel)
                {
                    return;
                }
                else
                    ShouldBeTheFileName = FileOpener.SafeFileName;

            }
            else
            {
                ClassCodeTempelate = FileOpener.SafeFileName.Split('_')[0];
                ShouldBeTheFileName = FileOpener.SafeFileName;
            }
            ListView_Uncheck.ShowGroups = true;
            ListView_Uncheck.Items.Clear();
            CheckedListView.Items.Clear();
            NotCheckedSingleStudents.Clear();
            CheckedSingleStudents.Clear();
            foreach (SingleStudent SS in DP.GetStudents(Data))
            {
                //ListView_Uncheck.Items.Add(SS.LastName + " " + SS.FirstName);
                NotCheckedSingleStudents.Add(SS);
                List<String> Meow = new List<string>();
                Meow.Add(SS.LastName);
                Meow.Add(SS.FirstName);
                Meow.Add(SS.Index);
                ListView_Uncheck.Items.Add(new ListViewItem(Meow.ToArray()));
            }
            foreach (SingleStudent SSNot in NotCheckedSingleStudents)
            {
                SSNot.State = "Not Checked";
            }
            Label_Current_File.Text = "Current File: " + FileOpener.SafeFileName;
            StudentListPanel.Show();
            BarCodeInputLabel.Show();
            this.Size = new Size(820, 574);
            LoadedStudentDataaaaa = true;
            Saved = false;
            StatueLabel.Text = "File Loaded!";
            classCode = ClassCodeTempelate;
            Properties.Settings.Default.ClassCode = classCode;
            Properties.Settings.Default.Save();
            Course_Index.Text = "Class code:\r\n" + classCode;
            Button_Save.Visible = true;
            Box_StudentIndex.Focus();

            //Course_Code_Selector_Dialog CCSD = new Course_Code_Selector_Dialog();
            //if(CCSD.ShowDialog() == DialogResult.OK)
            //{
            //}
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
                            stu.State = tk.perform(DateTime.Now, stu, CustomTimmmmmmmmmmmmmmmmmmmmme);
                            StatueLabel.Text = stu.FirstName + " " + stu.LastName + "\r\nhas been checked at\r\n" + DateTime.Now;
                            //Meow.Add(DateTime.Now.TimeOfDay.ToString("00:00"));
                            CheckedListView.Items.Add(new ListViewItem(Meow.ToArray()));
                            CheckedSingleStudents.Add(stu);
                            NotCheckedSingleStudents.Remove(stu);
                            ListView_Uncheck.Items.Remove((ListViewItem)OBJ);
                            Box_StudentIndex.Text = "";
                            Saved = false;
                            return;
                        }
                    }
                }
            }
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
                foreach (SingleStudent SSNot in NotCheckedSingleStudents)
                {
                    SSNot.State = "Absent";
                }
            }
            Saved = false;
        }
        /// <summary>
        /// Set all students(even checked) as unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SetAllCheckedStudentsAsUncheck_Click(object sender, EventArgs e)
        {
            foreach (SingleStudent stu in CheckedSingleStudents.ToArray())
            {
                foreach (object OBJ in CheckedListView.Items)
                {
                    if (OBJ.ToString().Contains(stu.LastName))
                    {
                        List<String> Meow = new List<string>();
                        Meow.Add(stu.LastName);
                        Meow.Add(stu.FirstName);
                        Meow.Add(stu.Index);
                        stu.AttandanceTime = new DateTime();
                        stu.State = "Unchecked";
                        NotCheckedSingleStudents.Add(stu);
                        ListView_Uncheck.Items.Add((new ListViewItem(Meow.ToArray())));
                        CheckedListView.Items.Remove((ListViewItem)OBJ);
                        CheckedSingleStudents.Remove(stu);
                        Box_StudentIndex.Text = "";
                    }
                }
            }
            StatueLabel.Text = "All checked \r\nstudents has been \r\nmarked as \r\nunchecked.";
            Saved = false;
        }

        private void Button_EditEmailFormat_Click(object sender, EventArgs e)
        {
            EmailEditorDialog EED = new EmailEditorDialog();
            if (EED.ShowDialog() == DialogResult.OK)
            {
                ///It needs to do nothing
            }
        } 

        private void Button_TeacherManagement_Click(object sender, EventArgs e)
        {
            if (IsTeacherManagementOpened)
            {
                TeacherManagementPanel.Hide();
                Button_TeacherManagement.Text = "Show Teacher Management";
                TimeEditing.Visible = false;
                PersonalData.Visible = false;
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

        NetworkCredential userLogin;
        SmtpClient smtpc;
        MailMessage mail;

        private void SendMailButtonClick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EmailAddress.Length == 0 )
            {
                MessageBox.Show("Please set your Gmail bot first!");
                Email_Account_Editor EAE = new Email_Account_Editor(DP);
                 if (EAE.ShowDialog() == DialogResult.OK)
                {
                }
                 else
                {
                    return;
                }
            }
            if (Properties.Settings.Default.EmailFormatTitle.Length == 0)
            {
                MessageBox.Show("Please set your email format first!");
                EmailEditorDialog EED = new EmailEditorDialog();
                if (EED.ShowDialog() == DialogResult.OK)
                {
                }
                else
                {
                    return;
                }
            }
            SendMailSelector SMS = new SendMailSelector();
            if (SMS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool ToAbsent = SMS.Absent_Student_Checkbox.Checked;
                bool ToLate = SMS.Late_Students_Checkbox.Checked;
                bool ToUnc = SMS.Unchecked_Students_Checkbox.Checked;
                if (ToLate)
                {
                    foreach (SingleStudent SS in CheckedSingleStudents)
                    {
                        if (SS.State.Contains("Late"))
                        {
                            //MessageBox.Show(DP.MailReplacer(DateTime.Now, tk.perform(DateTime.Now, SS, CustomTimmmmmmmmmmmmmmmmmmmmme), SS, Properties.Settings.Default.EmailFormatTitle));
                            //MessageBox.Show(DP.MailReplacer(DateTime.Now, tk.perform(DateTime.Now, SS, CustomTimmmmmmmmmmmmmmmmmmmmme), SS, Properties.Settings.Default.EmailFormatMain));
                            MailSender(SS, DateTime.Now, tk.perform(SS.AttandanceTime, SS, CustomTimmmmmmmmmmmmmmmmmmmmme));
                        }
                    }
                }

                foreach (SingleStudent SS in NotCheckedSingleStudents)
                {
                    if (SS.State == "Not Checked" && ToUnc)
                    {
                        MailSender(SS, DateTime.Now, SS.State);
                    }
                    else if (SS.State == "Absent" && ToAbsent)
                    {
                        MailSender(SS, DateTime.Now, SS.State);
                    }
                }
            }
            StatueLabel.Text = "Mail Sent!";
        }
        /// <summary>
        /// Send a mail to a specific student with late data
        /// </summary>
        /// <param name="Student">A SingleStudent Instance</param>
        /// <param name="time">Time now</param>
        /// <param name="LateData">Late Data</param>
        public void MailSender(SingleStudent Student, DateTime time, String LateData)
        {
            userLogin = new NetworkCredential(Properties.Settings.Default.EmailAddress, DP.PasswordDecryptor(Properties.Settings.Default.EmailPosswordEncrypted, 12));//user's email address and password
            smtpc = new SmtpClient("smtp.gmail.com");
            smtpc.Port = 587;//normal port 
            smtpc.Credentials = userLogin;//apply user's info
            mail = new MailMessage { From = new MailAddress(Properties.Settings.Default.EmailAddress, "CKSSmailer", Encoding.UTF8) };//get sending address
            foreach (string MA in Student.EmailAddress.Split(';'))
            {
                MA.Replace(" ", ", ");
                mail.To.Add(new MailAddress(MA));//get receving address
            }
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
                MessageBox.Show("Sending process cancelled");
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
            Email_Account_Editor ema = new Email_Account_Editor(DP);
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

        private void Button_SetTime_Click(object sender, EventArgs e)
        {
            int hhh;
            int mmm;
            DateTime DTNOW = DateTime.Now;
            
            if (int.TryParse(StartHour.Text, out hhh) && int.TryParse(StartMinute.Text, out mmm))
            {
                CustomTimmmmmmmmmmmmmmmmmmmmme = new DateTime(DTNOW.Year, DTNOW.Month, DTNOW.Day, hhh, mmm, 0);
                CheckedStudentsTimeUpdate();
            }
        }

        private void EditClassStarTime_Click(object sender, EventArgs e)
        {
            TimeSetter TSSetStart = new TimeSetter(false);
            TSSetStart.NUD_Hrs.Value = CustomTimmmmmmmmmmmmmmmmmmmmme.Hour;
            TSSetStart.NUD_Min.Value = CustomTimmmmmmmmmmmmmmmmmmmmme.Minute;
            if (TSSetStart.ShowDialog() == DialogResult.OK)
            {
                int Min = (int)TSSetStart.NUD_Min.Value;
                int Hrs = (int)TSSetStart.NUD_Hrs.Value;
                CustomTimmmmmmmmmmmmmmmmmmmmme = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Hrs, Min, 0);
                CheckedStudentsTimeUpdate();
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
            FileSaver.FileName = ShouldBeTheFileName;
            FileSaver.ShowDialog();
        }

        void CheckedStudentsTimeUpdate()
        {
            CheckedListView.Items.Clear();
            foreach (SingleStudent stu in CheckedSingleStudents)
            {
                List<String> Meow = new List<string>();
                Meow.Add(stu.LastName);
                Meow.Add(stu.FirstName);
                Meow.Add(stu.Index);
                Meow.Add(tk.perform(DateTime.Now, stu, CustomTimmmmmmmmmmmmmmmmmmmmme));
                stu.State = tk.perform(DateTime.Now, stu, CustomTimmmmmmmmmmmmmmmmmmmmme);
                CheckedListView.Items.Add((new ListViewItem(Meow.ToArray())));
            }
            StatueLabel.Text = "Time record has \r\nbeen updated!";
            Saved = false;
        }

        private void FileSaver_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                DP.SaveDailyFiles(CheckedSingleStudents, NotCheckedSingleStudents, FileSaver.FileName, DateTime.Now, classCode, CustomTimmmmmmmmmmmmmmmmmmmmme);
                StatueLabel.Text = "File Saved!";
                Saved = true;
            }
            catch(Exception ee)
            {
                MessageBox.Show("Something wrong happened with saving! Please post the exception below to developers for improvements! Thanks! \r\n" + ee.ToString());
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Saved)
            {
                DialogResult DR = MessageBox.Show("You did not save the attendance data! would you like to save it now?", "Not saved!", MessageBoxButtons.YesNoCancel);
                //If yes, create new one; if no, go on; if cancel, return.
                if (DR == DialogResult.Yes)
                {
                    SaveData_Click(new object(), new EventArgs());
                }
                else if (DR == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        void SavingToTempelate ()
        {
            //Properties.Settings.Default.VeryTempWrongClosingUncheck = new SingleStudentCollection(NotCheckedSingleStudents);

        }
    }
}
