using System;
using System.Collections.Generic;
using System.Text;

namespace DanceSchoolApp.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age} yo";
        }
    }
}
