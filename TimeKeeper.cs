using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Attendance_Scanning
{
    //This class will take the students time and say if they are on time or not
    class TimeKeeper 
    { 
       
       //this will call the functions below
       //call TimeBracket
    }

    public class TimeBracket
    {
        //this is the time limit a student has before being marked absnt
        //will use TimeLog and SwipeIn 
        //hh:mm is the hour and minute; dd:mm:yy is date, month, and year

        ClassTime = hh:mm/ dd:mm:yy;

        TimeLIMIT = StopWatch;
        
        
    }

    public class StopWatch{
        //this starts a timer after the class begins and tells TimeBracket how much time the student was late of absent
        Period1_Time = 08:10 - 09:25;
        Period2_Time = 09:30 - 10:45;
        Period3_Time = 10:50 - 12:00;
        Period4_Time = 12:05 - 01:15;
        Period5_Time = 01:20 - 02:45;

        //TimeLimit will check with these times and TimeBracket will send the data to TimeLog
       

    }

    public class TimeLog
    {
        //This logs the students into the system when they scan their cards
        var TimeIN; 
        var TimeLATE;
        var TimeABSENT;
           
        if(TimeLATE > TimeIN){
            Console.WriteLine = StudentID + "is late to class by" + hh:mm;
        }

        else if(TimeABSENT > TimeLIMIT){
            Console.WriteLine = StudentID + "is absent from class on" + mm:dd:yy;
        }

        else{
            Console.WriteLine = StudentID + "is on time for class";
        }

    }

    public enum ScanIn
    {
        //extends to the scanning feature Charlie is working on
        TimeIN;
        TimeLATE;
        TimeABSENT;
    }
}
