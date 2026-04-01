using System;
using System.Collections.Generic;
using System.Text;

namespace DanceSchoolApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new();
        public Teacher Teacher { get; set; }

        public override string ToString()
        {
            return $"{Name}, ({Teacher.Name}), {Students.Count()}";
        }
    }
}
