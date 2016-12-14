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
        int WhichOne = 7;
        public List<SingleStudent> stustu;
        /// <summary>
        /// Initialize the class code selector with the file
        /// </summary>
        /// <param name="File"></param>
        public ClassCodeSelector(string[] File)
        {
            InitializeComponent();
            ThyFile = File.ToList();
            try
            {
                NoIWouldLikeSpike();
            } 
            catch
            {
                MessageBox.Show("Not A Valid File!");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            ClassCodeComboBox.Text = "Please type in here or select a value.";
        }

        void NoIWouldLikeSpike()
        {
            WhichOne = 7;
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
                    ClassCodeComboBox.AutoCompleteCustomSource.Add(Nope);
                }
            }
        }

        private void ClassCodeComboBox_TextChanged(object sender, EventArgs e)
        {
            FinalReturningClassCode = ClassCodeComboBox.Text;
            if (ClassCodeComboBox.Text.Length == 0 && !Changing)
            {
                ClassCodeComboBox.Text = "Please type in here or select a value.";
            }
            Changing = false;
        }

        private void ClassCodeComboBox_GotFocus(object sender, EventArgs e)
        {
            if (ClassCodeComboBox.Text == "Please type in here or select a value.")
            {
                Changing = true;
                ClassCodeComboBox.Text = "";
            }
        }

        private void ClassCodeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (ClassCodeComboBox.Text.Contains("select") && e.KeyCode.ToString().Length == 1)
            {
                Changing = true;
                ClassCodeComboBox.Text = "";
            }
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            if(!ClassCodeComboBox.Text.Contains("select"))
            {
                stustu = new List<SingleStudent>();
                foreach (string SingleLine in ThyFile)
                {
                    string[] TheLine = SingleLine.Split(',');
                    if (TheLine[WhichOne] == ClassCodeComboBox.Text)
                    {
                        SingleStudent SS = new SingleStudent(TheLine[2], TheLine[1], TheLine[0], TheLine[12]);
                        stustu.Add(SS);
                    }
                }
                if(stustu.Count <= 0)
                {
                    MessageBox.Show("No student has this course!");
                    return;
                }
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
