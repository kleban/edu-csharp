
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesApp.ConsoleApp.Models
{
    public abstract class Person
    {
        protected int age;
        protected string name;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
    }
}
