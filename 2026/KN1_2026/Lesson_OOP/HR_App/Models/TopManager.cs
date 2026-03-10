using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public class TopManager : Manager
    {
        protected double companyShare;

        public TopManager(string name, int age, double salary, int wcount, double share)
            : base(name, age, salary, wcount)
        {
            companyShare = share;
        }

        public override double GetFullSalary()
        {
            return base.GetFullSalary() + companyShare*1000;
        }

        public override string GetInfo()
        {
            return "Top Manager" + $": {name}, {age} y.o., ${GetFullSalary():f2}" + $", Workers: {workersCount}, %{companyShare*100:f2}";
        }

        public double GetCompanyShare()
        {
            return companyShare*100;
        }
    }
}
