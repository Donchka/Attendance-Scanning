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
        public String LastName = "";
        public List<string> CourseCodes;
        public String FirstName = "";
        public String EmailAddress = "";
        public DateTime AttandanceTime = new DateTime();
        /// <summary>
        /// Real Type
        /// </summary>
        /// <param name="MyIndex"></param>
        /// <param name="MyFirstName"></param>
        /// <param name="MySecondName"></param>
        /// <param name="MyEmail"></param>
        /// <param name="MyCourseCode"></param>
        public SingleStudent(String MyIndex, String MyFirstName, string MySecondName, string MyEmail, string MyCourseCode)
        {
            Index = MyIndex;
            LastName = MyFirstName;
            FirstName = MySecondName;
            EmailAddress = MyEmail;
            CourseCodes = MyCourseCode.Split(' ').ToList();
        }
        /// <summary>
        /// Dommy Type
        /// </summary>
        /// <param name="MyIndex"></param>
        /// <param name="MyFirstName"></param>
        /// <param name="MySecondName"></param>
        /// <param name="MyEmail"></param>
        public SingleStudent(String MyIndex, String MyFirstName, string MySecondName, string MyEmail)
        {
            Index = MyIndex;
            LastName = MyFirstName;
            FirstName = MySecondName;
            EmailAddress = MyEmail;
        }
        public bool IsMe(String ThyIndex)
        {
            return (ThyIndex.Contains(Index));
        }
    }
}
