using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.SortDemo
{
    public class StudentAgeComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            /*if(x.Age > y.Age)
                return 1;
            else if (x.Age < y.Age)
                return -1;
            else
                return 0;*/

            return x.Age > y.Age ? 1 : x.Age < y.Age ? -1 : 0;
        }
    }
}
