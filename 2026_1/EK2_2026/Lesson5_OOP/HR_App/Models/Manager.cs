using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public class Manager : Worker
    {
        protected int workersCount;

        public Manager(string name, 
            DateTime dob, 
            double salary,
            int wcount) : base(name, dob, salary)
        {
            workersCount = wcount;
        }

        public override double GetFullSalary()
        {
            return salary + workersCount * 15;
        }

        public override string GetInfo()
        {
            string str = "Manager: ";
            str += base.GetInfo();
            str += $"Workers: {workersCount}.";
            return str;
        }
    }
}
