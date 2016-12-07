using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Scanning
{
    public class SingleStudentCollection
    {
        List<SingleStudent> collection;
        public SingleStudentCollection(List<SingleStudent> Lst)
        {
            collection = Lst;
        }
    }
}
