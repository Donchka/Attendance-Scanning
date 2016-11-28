using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;


namespace Attendance_Scanning
{
    //This class will take the students time and say if they are on time or not
    class TimeKeeper
    {
        //this will call the functions below
        //call TimeBracket


        public DateTime TimeBracket()
        {
            //this is the time limit a student has before being marked absnt
            //will use TimeLog and SwipeIn 
            //hh:mm is the hour and minute; dd:mm:yy is date, month, and year

            DateTime date1 = DateTime.Now;
            //StopWatch start;
            return date1;
            //resets every period
        }

        public void StopWatch() {
            //this starts a timer after the class begins and tells TimeBracket how much time the student was late of absent
            DateTime Period1_Time = new DateTime(2016, 11, 24, 8, 10, 0);//8:10
            DateTime Period2_Time = new DateTime(2016, 11, 24, 9, 30, 0);//9:30
            DateTime Period3_Time = new DateTime(2016, 11, 24, 10, 50, 0);//10:50
            DateTime Period4_Time = new DateTime(2016, 11, 24, 12, 5, 0);//12:05
            DateTime Period5_Time = new DateTime(2016, 11, 24, 13, 20, 0);//13:20
            
            //TimeLimit will check with these times and TimeBracket will send the data to TimeLog
            Timer timeLIMIT = new Timer();
            string timeLIMITS = ""; //30 minute time limit preset; teacher can change limit in TeacherSettings
            TimeSpan diff = DateTime.Now - Period4_Time;
            Console.WriteLine(diff);
        }



        public void TimeLog()
        {
            //This logs the students into the system when they scan their cards
            //after being logged, the data is sent to a student array
            int TimeIN;
            string StudentID = "Charlie";
            DateTime temp = TimeBracket();
            string Current = temp.ToString();

            //if (TimeIN <= StopWatch) {
            //    Console.WriteLine(StudentID + " is late for class on " + Current + " by " + Current);
            //}
            //if (TimeIN > StopWatch) {
            //    Console.WriteLine(StudentID + " is absent for class on " + Current);
            //}
            //else {
            //    Console.WriteLine(StudentID + " is on time for class on " + Current);
            //}
   
    }
}
    //    public enum ScanIn
    //    {
    //    //extends to the scanning feature Charlie is working on
    //    int TimeIN;
    //    int TimeLATE;
    //    int TimeABSENT;
    //}


    //this is where teachers are allowed to manipulate the software to their rules
    public class TeacherSettings{
        
        //increase or decrease time limit
        //I need the form in order to connect this setting                

    }
}

