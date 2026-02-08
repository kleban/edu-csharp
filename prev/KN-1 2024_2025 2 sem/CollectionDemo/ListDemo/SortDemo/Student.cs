using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.SortDemo
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public int CompareTo(Student? other)
        {
            if (Name.CompareTo(other.Name) == 1)
                return 1;
            else if (Name.CompareTo(other.Name) == -1)
                return -1;
            return 0;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} y.o: {Grade:f2}";
        }
    }
}
