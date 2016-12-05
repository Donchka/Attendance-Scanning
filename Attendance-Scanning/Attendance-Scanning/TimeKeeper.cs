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
    public class TimeKeeper
    {

        public DateTime[] Period_Times;
        public DateTime[] Period_Ring_Times;
        //this will call the functions below
        //call TimeBracket

        int period;
        TimeSpan diff;
        //TimeSpan lateInterval;
        //TimeSpan temp;



        public void updateTime(DateTime Cust)
        {
            int yearNow = DateTime.Now.Year;
            int monthNow = DateTime.Now.Month;
            int dayNow = DateTime.Now.Day;

            Period_Times = new DateTime[] {
        new DateTime (yearNow, monthNow, dayNow, 8, 13, 0),//8:10
        new DateTime (yearNow, monthNow, dayNow, 9, 30, 0),//9:30
        new DateTime (yearNow, monthNow, dayNow, 10, 47, 0),//10:50
        new DateTime (yearNow, monthNow, dayNow, 12, 4, 0),//12:05
        new DateTime (yearNow, monthNow, dayNow, 13, 21, 0),//13:20    
        };

            Period_Ring_Times = new DateTime[]
            {
        new DateTime (yearNow, monthNow, dayNow, 8, 00, 0),//8:10
        new DateTime (yearNow, monthNow, dayNow, 9, 27, 0),//9:30
        new DateTime (yearNow, monthNow, dayNow, 10, 44, 0),//10:50
        new DateTime (yearNow, monthNow, dayNow, 12, 1, 0),//12:05
        new DateTime (yearNow, monthNow, dayNow, 13, 18, 0),//13:20   
            };

            if (Cust!=new DateTime())
            {
                identifyPeriod(Cust);
                Period_Times[period] = Cust;
            }

        }

        public TimeSpan StopWatch(DateTime Dt) {
            //this starts a timer after the class begins and tells TimeBracket how much time the student was late of absent

            //TimeLimit will check with these times and TimeBracket will send the data to TimeLog

            diff = Dt - Period_Times[period];

            return diff;
        }

        public void identifyPeriod(DateTime d)//get the current period
        {
            
            for(int i = 0; i < 5; i++)
            {
                if (d >= Period_Ring_Times[4])
                {
                    period = 4;
                    //Console.WriteLine("iya" + i);
                    //Console.WriteLine(Period_Times[i + 1]);
                    Console.WriteLine(d);
                }
                else if(d>=Period_Ring_Times[i] && d < Period_Ring_Times[i + 1])
                {

                    //lateInterval = d - Period_Ring_Times[i+1];
                    //temp = Period_Times[i+1] - Period_Ring_Times[i+1];
                    //Console.WriteLine("temp" + temp.ToString());
                    //Console.WriteLine("iya" + i);
                    //Console.WriteLine(Period_Times[i + 1]);
                    Console.WriteLine(d);
                    //Console.WriteLine(lateInterval.ToString());
                    //if (lateInterval.Hours == 0 && lateInterval.Minutes <= (temp.Minutes))
                    //    period = i + 1;
                    //else
                    //    period = i;

                    period = i;

                    Console.WriteLine("period" + period);

                }
            }
        }

        public string TimeLog(DateTime TimeIN,SingleStudent SS)
        {
            //This logs the students into the system when they scan their cards
            //after being logged, the data is sent to a student array
            string zuosi = "";
            TimeSpan timeLIMIT = new TimeSpan(0,30,0);
            int result = TimeSpan.Compare(diff, timeLIMIT);//30 minute time limit preset; teacher can change limit in TeacherSettings

            if (TimeIN > Period_Times[period])
            {
                //Console.WriteLine(SS.LastName + " is late for period " + (period+1) + " class on " + TimeIN.Year + "." + TimeIN.Month + "." + TimeIN.Day + " for " + diff.Hours + "hours and " + diff.Minutes + "minutes");
                //zuosi = SS.LastName + " is late for period " + (period+1) + " class on " + TimeIN.Year + "." + TimeIN.Month + "." + TimeIN.Day + " for " + diff.Hours + "hours and " + diff.Minutes + "minutes";
                zuosi = "Late at period " + (period + 1) + " : " + diff.Hours + " h " + diff.Minutes + " m";
            }
            else if ((TimeIN > Period_Times[period] && result == 1) || (TimeIN > Period_Times[period] && result == 0))
            {

                //Console.WriteLine(SS.LastName + " is absent for period " + (period+1) + " class on " + TimeIN.Year + "." + TimeIN.Month + "." + TimeIN.Day);
                //zuosi = SS.LastName + " is absent for period " + (period+1) + " class on " + TimeIN.Year + "." + TimeIN.Month + "." + TimeIN.Day;               
            }
            else if (TimeIN < Period_Times[period])
            {
                zuosi = "On Time";
            }
            return zuosi;
        }

        /// <summary>
        /// Do things
        /// </summary>
        /// <param name="CheckInTime">Time Students checked in</param>
        public string perform(DateTime CheckInTime, SingleStudent TheStu,DateTime CustomTime)
        {
            string stuMess;
            updateTime(CustomTime);
            identifyPeriod(CheckInTime);
            StopWatch(CheckInTime);
            stuMess = TimeLog(CheckInTime,TheStu);

            return stuMess;
        }

    }
}
    //    public enum ScanIn
    //    {
    //    //extends to the scanning feature Charlie is working on
    //    int TimeIN;
    //    int TimeLATE;
    //    int TimeABSENT;
    //}




