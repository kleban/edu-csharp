using System;
using System.Collections.Generic;
using System.Text;

namespace DataReadWright
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{Name} (Age: {Age}, Grade: {Grade})";
        }
    }
}
