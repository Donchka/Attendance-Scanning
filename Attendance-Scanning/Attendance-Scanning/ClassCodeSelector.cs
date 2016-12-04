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
    public partial class ClassCodeSelector : Form
    {
        List<string> ThyFile;
        string FinalReturningClassCode;
        bool Changing = false;
        /// <summary>
        /// Initialize the class code selector with the file
        /// </summary>
        /// <param name="File"></param>
        public ClassCodeSelector(string[] File)
        {
            InitializeComponent();
            ThyFile = File.ToList();
            NoIWouldLikeSpike();
            ClassCodeComboBox.Text = "Please type in here or select a value.";
        }

        void NoIWouldLikeSpike()
        {
            int WhichOne = 7;
            ThyFile.RemoveAt(0);
            if (ThyFile[0].Split(',')[7].Length < 2)
            {
                WhichOne = 6;
            }
            foreach(string SingleLine in ThyFile)
            {
                string Nope = SingleLine.Split(',')[WhichOne];
                if (!ClassCodeComboBox.Items.Contains(Nope))
                {
                    ClassCodeComboBox.Items.Add(Nope);
                }
            }
        }

        private void ClassCodeComboBox_TextChanged(object sender, EventArgs e)
        {
            FinalReturningClassCode = ClassCodeComboBox.Text;
            if(ClassCodeComboBox.Text.Length == 0 && !Changing)
            {
                ClassCodeComboBox.Text = "Please type in here or select a value.";
            }
            Changing = false;
        }

        private void ClassCodeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (ClassCodeComboBox.Text.Contains("select") && e.KeyCode.ToString().Length == 1)
            {
                Changing = true;
                ClassCodeComboBox.Text = "";
            }
        }
    }
}
