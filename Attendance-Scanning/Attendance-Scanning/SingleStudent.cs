using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Scanning
{
    public class SingleStudent
    {
        public String Index = "";
        public String FirstName = "";
        public String SecondName = "";
        public String EmailAddress = "";

        public SingleStudent(String MyIndex, String MyFirstName, string MySecondName, string MyEmail)
        {
            Index = MyIndex;
            FirstName = MyFirstName;
            SecondName = MySecondName;
            EmailAddress = MyEmail;
        }
    }
}
