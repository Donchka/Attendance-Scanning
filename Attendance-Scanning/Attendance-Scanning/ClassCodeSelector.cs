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
        Data_Processor DP;
        /// <summary>
        /// Initialize the class code selector with the file
        /// </summary>
        /// <param name="File"></param>
        public ClassCodeSelector(string[] File, Data_Processor DPpp)
        {
            InitializeComponent();
            DP = DPpp;
            ThyFile = File.ToList();

            foreach (string Title in ThyFile[0].Split(','))
            {
                ColumnComboBox.Items.Add(Title);
            }
            try
            {
                NoIWouldLikeSpike(0, false);
            }
            catch
            {
                MessageBox.Show("Not A Valid File!");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            ClassCodeComboBox.Text = "Please type in here or select a value.";


        }

        void NoIWouldLikeSpike(int Given, bool Gived)
        {
            if (!Gived)
            {
                WhichOne = DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "ourse", 0);
                //Warning: Complex Logic below 随便打个客户
                if (WhichOne == -1)
                {
                    WhichOne = DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "rogram", 0);
                    if (WhichOne == -1)
                    {
                        MessageBox.Show("Cannot get the column for class codes! Please manually set that!");
                        return;
                    }
                    else if (ThyFile[1].Split(',')[WhichOne].Length < 2)
                    {
                        MessageBox.Show("Cannot get the column for class codes! Please manually set that!");
                        return;
                    }
                }
                else if (ThyFile[1].Split(',')[WhichOne].Length < 2)
                {
                    WhichOne = DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "rogram", 0);
                    if (WhichOne == -1)
                    {
                        MessageBox.Show("Cannot get the column for class codes! Please manually set that!");
                        return;
                    }
                    else if (ThyFile[1].Split(',')[WhichOne].Length < 2)
                    {
                        MessageBox.Show("Cannot get the column for class codes! Please manually set that!");
                        return;
                    }
                }
            }
            else
            {
                WhichOne = Given;
            }
            List<string> ThyThyFile = ThyFile.ToList();
            ThyThyFile.RemoveAt(0);
            foreach (string SingleLine in ThyThyFile)
            {
                string Nope = SingleLine.Split(',')[WhichOne];
                foreach (string YUS in Nope.Split(' '))
                {
                    if (!ClassCodeComboBox.Items.Contains(YUS))
                    {
                        ClassCodeComboBox.Items.Add(YUS);
                        ClassCodeComboBox.AutoCompleteCustomSource.Add(YUS);
                    }
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
            stustu = new List<SingleStudent>();
            if (ClassCodeComboBox.Items.Contains(ClassCodeComboBox.Text))
            {
                if (!ClassCodeComboBox.Text.Contains("select"))
                {
                    stustu = new List<SingleStudent>();
                    foreach (string SingleLine in ThyFile)
                    {
                        string[] TheLine = SingleLine.Split(',');
                            if (SingleLine.Contains(ClassCodeComboBox.Text))//If the student has this course
                            {
                                try
                                {
                                    SingleStudent SS = new SingleStudent(
                                        TheLine[DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "umber", 0)],
                                        TheLine[DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "irst", 0)],
                                        TheLine[DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "ast", 0)],
                                        TheLine[DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "ianEmai", 0)]);
                                    stustu.Add(SS);
                                }
                                catch (Exception eee)
                                {
                                    MessageBox.Show("ERROR! Please send this to the developers:" + eee.ToString());
                                }
                            }
                    }
                    if (stustu.Count <= 0)
                    {
                        MessageBox.Show("No student has this course!");
                        return;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (MessageBox.Show("Your class code does not exist in the possible class code selections! \r\nWould you still like to search for possible students in your given class code? \r\n Note: You can select No and then try select another column.", "Cannot find certain class code", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (string SingleLine in ThyFile)
                    {
                        string[] TheLine = SingleLine.Split(',');
                        if (SingleLine.ToUpper().Contains(ClassCodeComboBox.Text.ToUpper()))//If the student has this course
                        {
                            try
                            {
                                SingleStudent SS = new SingleStudent(
                                    TheLine[DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "umber", 0)],
                                    TheLine[DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "irst", 0)],
                                    TheLine[DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "ast", 0)],
                                    TheLine[DP.FindFirstStringIndexFromAnArray(ThyFile[0].Split(','), "ianEmai", 0)]);
                                stustu.Add(SS);
                            }
                            catch (Exception eee)
                            {
                                MessageBox.Show("ERROR! Please send this to the developers:" + eee.ToString());
                            }
                        }
                    }
                    if (stustu.Count <= 0)
                    {
                        MessageBox.Show("No student has this course! Please ensure the file and your class code!");
                        return;
                    }
                }
            }
        }

        private void ColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassCodeComboBox.Items.Clear();
            ClassCodeComboBox.AutoCompleteCustomSource.Clear();
            NoIWouldLikeSpike(ColumnComboBox.SelectedIndex, true);
        }
    }
}
