using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group {  get; set; }
        public double AvgGrade { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Group}): {AvgGrade}";
        }
    }
}
