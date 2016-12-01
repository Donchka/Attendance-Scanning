using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Scanning
{
    public class Data_Processor
    {
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
                    FinalReturner += student.SecondName + " " + student.FirstName;
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
        /// <returns>a string of date time splited by ','</returns>
        public string FromDateTimeToString(DateTime DT)
        {
            return DT.Year + "," + DT.Month + "," + DT.Day;
        }
        /// <summary>
        /// Covert a string to a DateTime
        /// </summary>
        /// <param name="SSS">Datetime String. using ',' to split year, month and days</param>
        /// <returns>A datetime</returns>
        public DateTime FromStringToDateTime(String SSS)
        {
            return new DateTime(int.Parse(SSS.Split(',')[0]), int.Parse(SSS.Split(',')[1]), int.Parse(SSS.Split(',')[2]));
        }
    }
}
