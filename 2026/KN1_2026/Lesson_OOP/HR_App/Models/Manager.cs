using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public class Manager : Worker
    {
        protected int workersCount;
        public Manager(string name, int age, double salary, int wcount) : base(name, age, salary)
        { 
           workersCount = wcount;
        }

        public override string GetInfo()
        {
            return "Manager" + base.GetInfo() + $", Workers: {workersCount}";
        }

        public int WorkersCount
        {
            get { return workersCount; }
        }

        public override double GetFullSalary()
        {
            return salary + 10 * workersCount;
        }
    }
}
