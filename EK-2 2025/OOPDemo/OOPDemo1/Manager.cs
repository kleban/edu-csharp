using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPDemo1
{
    public class Manager : Worker
    {
        protected int numberOfSubordinates;

        public Manager() : base()
        {
            numberOfSubordinates = 0;
        }

        public Manager(string name, int age, double salary, int n) 
            : base(name, age, salary)
        {
            this.numberOfSubordinates = n;
        }

        public override string ToString()
        {
            return $"Manager: {name}: {age} years old, ${salary} ---> {numberOfSubordinates}";
        }
    }
}
