using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Attendance_Scanning
{
    public partial class EmailEditorDialog : Form
    {
        NetworkCredential userLogin;
        SmtpClient smtpc;
        MailMessage mail;

        public EmailEditorDialog()
        {
            InitializeComponent();
        }

        private void StudentLateTimeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
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

        private static void notification(object sender,AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("send cancelled");
            }else if (e.Error!=null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else
            {
                MessageBox.Show("Message sent.");
            }
        }
    }



}
