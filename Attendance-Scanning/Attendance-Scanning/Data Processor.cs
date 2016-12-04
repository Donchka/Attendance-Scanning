using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
        public string MailReplacer(DateTime time,String LateData , SingleStudent student,String NeedToBeReplaced)
        {
            string FinalReturner = "";
            foreach (string Words in NeedToBeReplaced.Split(' '))
            {
                if (Words == "<StudentName>")
                {
                    FinalReturner += student.FirstName + " " + student.LastName;
                }
                else if (Words == "<StudentLateTime>")
                {
                    FinalReturner += LateData;
                }
                else if (Words == "<ClassName>")
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
        public List<SingleStudent> CSVCovertor (string[] Data)
        {
            List<SingleStudent> MultipleStudents = new List<SingleStudent>();
            List<string> RealData = Data.ToList();
            foreach(string inini in RealData)
            {
                if(inini.Contains("Last Name"))
                {
                    RealData.Remove(inini);
                    break;
                }
            }
            foreach (string str in RealData)
            {
                List<string> strList = str.Split(',').ToList();
                SingleStudent ST = new SingleStudent(strList[3], strList[0], strList[1], strList[12]/*,strList[14]*/);
                MultipleStudents.Add(ST);
            }
            return MultipleStudents;
        }

        /// <summary>
        /// To save a file of daily records. Available for first creation. Available for First Name, Last Name, Student ID and daily records. 
        /// </summary>
        /// <param name="CheckedStudents">For those who has been checked, include late</param>
        /// <param name="UncheckedStudents">For those who has been unchecked, include absent</param>
        /// <param name="FilePathAndName">From the FileLoadDialog.FileName</param>
        /// <param name="Date">Date today, or any given day</param>
        /// <param name="ClassCode">The class code the teacher is in</param>
        public void StudentsCovetor(List<SingleStudent> CheckedStudents, List<SingleStudent> UncheckedStudents, string FilePathAndName, DateTime Date,string ClassCode)
        {
            int columnToWrite;
            if (!File.Exists(FilePathAndName))
            {
                List<SingleStudent> SSFull = new List<SingleStudent>();
                SSFull.AddRange(CheckedStudents);
                SSFull.AddRange(UncheckedStudents);
                InitializeTheCSVFile(SSFull, ClassCode,FilePathAndName);
            }
            List<string> CsvFile = File.ReadAllLines(FilePathAndName).ToList();
            List<string> FirstRowOfColumns = CsvFile[0].Split(',').ToList();
            columnToWrite = FirstRowOfColumns.Count;
            for (int i = 0; i < FirstRowOfColumns.Count - 1; ++i)
            {
                if (FirstRowOfColumns[i].Contains((FromYYYYMMDDToString(Date))))
                {
                    columnToWrite = i;
                }
            }
            foreach(string line in CsvFile)
            {
                List<string> LSS = line.Split(',').ToList();
                foreach(SingleStudent SSChecked in CheckedStudents)
                {
                    if (SSChecked.IsMe(LSS[2]))
                    {
                        LSS[columnToWrite] = TK.perform(DateTime.Now, SSChecked, SSChecked.AttandanceTime);
                        CsvFile[CsvFile.IndexOf(line)] = LineCombiner(LSS,",");
                    }
                }
            }
            File.WriteAllLines(FilePathAndName, CsvFile,Encoding.Unicode);
        }
        /// <summary>
        /// To initialize a csv file for future usage
        /// </summary>
        /// <param name="SSs">Students that are in this class</param>
        /// <param name="ClassCode">Class code</param>
        /// <param name="PathAndName">The path and file name for creating the file</param>
        public void InitializeTheCSVFile(List<SingleStudent> SSs, string ClassCode,string PathAndName)
        {
            List<string> Lines = new List<string>();
            Lines.Add("Student Last Name,Student First Name,Student Number," + FromYYYYMMDDToString(DateTime.Today));
            foreach(SingleStudent ss in SSs)
            {
                Lines.Add(ss.LastName + "," + ss.FirstName + "," + ss.Index);
            }
            File.WriteAllLines(PathAndName, Lines, Encoding.Unicode);
        }

        public string LineCombiner(List<string> TheLine, string TheSpliter)
        {
            string returner = "";
            foreach(string TheSplitted in TheLine)
            {
                returner += TheSplitted;
                returner += TheSpliter;
            }
            returner.Remove(returner.Length - 1);
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
                    if(!ItContains)
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
        public DateTime FromStringToYYYYMMDD(String SSS)
        {
            return new DateTime(int.Parse(SSS.Split('-')[0]), int.Parse(SSS.Split('-')[1]), int.Parse(SSS.Split('-')[2]));
        }
    }
}
