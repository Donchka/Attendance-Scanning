using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using Excel = DocumentFormat.OpenXml.Spreadsheet;

namespace Attendance_Scanning
{
    public class Data_Processor
    {
        public TimeKeeper TK;
        public Data_Processor(TimeKeeper TKKK)
        {
            TK = TKKK;
        }
        /// <summary>
        /// Decrypte a string by char jumps
        /// </summary>
        /// <param name="EncyptedWord">the string that needs to be decrypated</param>
        /// <param name="Jump">the char jump</param>
        /// <returns>Decrypted string</returns>
        public string PasswordDecryptor(string EncyptedWord, int Jump)
        {
            string FinalResult = "";
            foreach (char SingleLetter in EncyptedWord.ToCharArray())
            {
                FinalResult += (char)(SingleLetter - Jump);
            }
            return FinalResult;
        }

        /// <summary>
        /// Encrypated a string by char jumps
        /// </summary>
        /// <param name="EncyptedWord">the string that needs to be encrypated</param>
        /// <param name="Jump">the char jump</param>
        /// <returns>Encrypated string</returns>
        public string PasswordEncryptor(string EncyptedWord, int Jump)
        {
            string FinalResult = "";
            foreach (char SingleLetter in EncyptedWord.ToCharArray())
            {
                FinalResult += (char)(SingleLetter + Jump);
            }
            return FinalResult;
        }
        /// <summary>
        /// Replace specific words to data. 
        /// </summary>
        /// <param name="time">The time today</param>
        /// <param name="LateData">tThe time that the sutdent have lated for</param>
        /// <param name="student">Student's data</param>
        /// <param name="NeedToBeReplaced"></param>
        /// <returns>The string of mail that has been replaced</returns>
        public string MailReplacer(DateTime time, String LateData, SingleStudent student, String NeedToBeReplaced)
        {
            string FinalReturner = "";
            foreach (string Words in NeedToBeReplaced.Split(' '))
            {
                if (Words == "<StudentName>")
                {
                    FinalReturner += student.FirstName + " " + student.LastName;
                }
                else if (Words == "<StudentStatueInfo>")
                {
                    FinalReturner += LateData;
                }
                else if (Words == "<ClassCode>")
                {
                    FinalReturner += Properties.Settings.Default.ClassCode;
                }
                else if (Words == "<TeacherName>")
                {
                    FinalReturner += Properties.Settings.Default.TeacherName;
                }
                else
                {
                    FinalReturner += Words;
                }
                FinalReturner += " ";
            }
            return FinalReturner;
        }


        /// <summary>
        /// Covert a csv file into list of single students
        /// </summary>
        /// <param name="Data">file data</param>
        /// <returns>List of single students</returns>
        public List<SingleStudent> GetStudents(string[] Data)
        {
            List<SingleStudent> MultipleStudents = new List<SingleStudent>();
            List<string> RealData = Data.ToList();
            foreach (string inini in RealData)
            {
                if (inini.Contains("Last Name"))
                {
                    RealData.Remove(inini);
                    break;
                }
            }
            foreach (string str in RealData)
            {
                List<string> strList = str.Split(',').ToList();
                SingleStudent ST = new SingleStudent(strList[2].Trim(), strList[0], strList[1], strList[3].Trim());
                MultipleStudents.Add(ST);
            }
            return MultipleStudents;
        }

        /// <summary>
        /// To save a file of daily records in csv format. Available for first creation. Available for First Name, Last Name, Student ID and daily records. 
        /// </summary>
        /// <param name="CheckedStudents">For those who has been checked, include late</param>
        /// <param name="UncheckedStudents">For those who has been unchecked, include absent</param>
        /// <param name="FilePathAndName">From the FileLoadDialog.FileName</param>
        /// <param name="Date">Date today, or any given day</param>
        /// <param name="ClassCode">The class code the teacher is in</param>
        public void SaveDailyFiles(List<SingleStudent> CheckedStudents, List<SingleStudent> UncheckedStudents, string FilePathAndName, DateTime Date, string ClassCode, DateTime CustomTimmmmmmmmmme)
        {
            int columnToWrite;
            if (!File.Exists(FilePathAndName))
            {
                List<SingleStudent> SSFull = new List<SingleStudent>();
                SSFull.AddRange(CheckedStudents);
                SSFull.AddRange(UncheckedStudents);
                InitializeTheCSVFile(SSFull, ClassCode, FilePathAndName);
            }
            List<string> CsvFile = File.ReadAllLines(FilePathAndName).ToList();
            List<string> FirstRowOfColumns = CsvFile[0].Split(',').ToList();
            columnToWrite = FirstRowOfColumns.Count;//Do not need -1

            for (int i = 0; i < FirstRowOfColumns.Count; ++i)
            {
                if (FirstRowOfColumns[i].Contains((FromYYYYMMDDToString(Date))))
                {
                    columnToWrite = i;
                }
            }
            bool DoAddAAolumn = false;
            if (columnToWrite == FirstRowOfColumns.Count)
            {
                CsvFile[0] += ", " + FromYYYYMMDDToString(Date);
                //DoAddAAolumn = true;
            }
            foreach (string line in CsvFile.ToArray())
            {
                List<string> LSS = line.Split(',').ToList();
                foreach (SingleStudent SSChecked in CheckedStudents)
                {
                    if (SSChecked.IsMe(LSS[2]))
                    {
                        if (DoAddAAolumn)//Actually will never be used
                            LSS.Add(TK.perform(SSChecked.AttandanceTime, SSChecked, CustomTimmmmmmmmmme));
                        else
                        {
                            try
                            {
                                LSS[columnToWrite] = TK.perform(SSChecked.AttandanceTime, SSChecked, CustomTimmmmmmmmmme);
                            }
                            catch
                            {
                                LSS.Add(TK.perform(SSChecked.AttandanceTime, SSChecked, CustomTimmmmmmmmmme));
                            }
                        }
                        CsvFile[CsvFile.IndexOf(line)] = LineCombiner(LSS, ", ");
                    }
                }
                foreach (SingleStudent SSUncke in UncheckedStudents)
                {
                    if (SSUncke.IsMe(LSS[2]))
                    {
                        if (DoAddAAolumn)//Actually will never be used
                            LSS.Add(SSUncke.State);
                        else
                        {
                            try
                            {
                                LSS[columnToWrite] = SSUncke.State;
                            }
                            catch
                            {
                                LSS.Add(SSUncke.State);
                            }
                        }
                        CsvFile[CsvFile.IndexOf(line)] = LineCombiner(LSS, ", ");

                    }
                }
            }
            File.WriteAllLines(FilePathAndName, CsvFile, Encoding.UTF8);
        }
        /// <summary>
        /// To initialize a csv file for future usage
        /// </summary>
        /// <param name="SSs">Students that are in this class</param>
        /// <param name="ClassCode">Class code</param>
        /// <param name="PathAndName">The path and file name for creating the file</param>
        public void InitializeTheCSVFile(List<SingleStudent> SSs, string ClassCode, string PathAndName)
        {
            List<string> Lines = new List<string>();
            Lines.Add("Student Last Name, Student First Name, Student Number, Guadian Email," + FromYYYYMMDDToString(DateTime.Today));
            foreach (SingleStudent ss in SSs)
            {
                Lines.Add(ss.LastName + "," + ss.FirstName + "," + ss.Index + "," + ss.EmailAddress);
            }
            File.WriteAllLines(PathAndName, Lines, Encoding.UTF8);
        }

        public string LineCombiner(List<string> TheLine, string TheSpliter)
        {
            string returner = "";
            foreach (string TheSplitted in TheLine)
            {
                returner += TheSplitted;
                returner += TheSpliter;
            }
            returner.Remove(returner.Length - TheSpliter.Length);
            return returner;
        }

        public List<string> CourseCodeCollector(List<SingleStudent> StudentList)
        {
            List<string> FinalReturner = new List<string>();
            foreach (SingleStudent stu in StudentList)
            {
                foreach (String CourseCode in stu.CourseCodes)
                {
                    bool ItContains = false;
                    //if (FinalReturner.Find(x => x == CourseCode) != null)
                    //{
                    //    ItContains = true;
                    //    break;
                    //}
                    foreach (String Goule in FinalReturner)
                    {
                        if (Goule == CourseCode)
                        {
                            ItContains = true;
                            break;
                        }
                    }
                    if (!ItContains)
                    {
                        FinalReturner.Add(CourseCode);
                    }
                }
            }
            return FinalReturner;
        }

        /// <summary>
        /// Covert a datetime to a string for saving. 
        /// </summary>
        /// <param name="DT">DateTime that is in the Year-Month-Date form</param>
        /// <returns>a string of date time splited by '-'</returns>
        public string FromYYYYMMDDToString(DateTime DT)
        {
            return DT.Year + "-" + DT.Month + "-" + DT.Day;
        }
        /// <summary>
        /// Covert a string to a DateTime
        /// </summary>
        /// <param name="SSS">Datetime String. using '-' to split year, month and days</param>
        /// <returns>A datetime</returns>
        public DateTime FromStringToYYYYMMDD(String SSSn)
        {
            String SSS = SSSn.Trim();
            return new DateTime(int.Parse(SSS.Split('-')[0]), int.Parse(SSS.Split('-')[1]), int.Parse(SSS.Split('-')[2]));
        }

        /// <summary>
        /// New method for saving files in excel format. 
        /// </summary>
        /// <param name="CheckedStudents"></param>
        /// <param name="UncheckedStudents"></param>
        /// <param name="FilePathAndName"></param>
        /// <param name="Date"></param>
        /// <param name="StartPoint"></param>
        /// <param name="ClassCode"></param>
        /// <param name="CustomTimmmmmmmmmme"></param>
        public void SaveDailyFiles(
            List<SingleStudent> CheckedStudents, 
            List<SingleStudent> UncheckedStudents, 
            string FilePathAndName, 
            string SafeName,
            DateTime Date, 
            DateTime StartPoint,
            string ClassCode, 
            DateTime CustomTimmmmmmmmmme)
        {
            int columnToWrite;
            DocumentFormat.OpenXml.Spreadsheet.Workbook EWC = new Workbook();
            //EWC.WorkbookPart.AddNewPart<WorkbookPart>();
            Worksheet StatusRecord = new Worksheet();
            Worksheet NotInClassMinuteRecord = new Worksheet();
            Worksheet ExactTimeRecord = new Worksheet();
            SpreadsheetDocument SSD = null;

            //StatusRecord.Name = "Student Status";
            //NotInClassMinuteRecord.Name = "During Class Absent time";
            //ExactTimeRecord.Name = "Attendance time";
            //StatusRecord.[2, 5] = "WTF";



         }
    }
}
