using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDemo.Models
{
    public class TopManager : Manager
    {
        protected double share;

        public TopManager(string name, DateTime dob, double salary,
            double bonus, int numberOfSubordinates, double share)
            : base(name, dob, salary, bonus, numberOfSubordinates)
        {
            this.share = share;
        }

        public double Share
        {
            get { return share; }
        }

        public override string GetInfo()
        {
            string info = $"****** Top Manager *******\n" +
               $"Name:\t{name}\nSalary:\t${GetTotalSalary()}\nAge:\t{Age} y.o.\nSubs.\t{numberOfSubordinates}\n" +
               $"Share:\t{share}%";
            return info;
        }

        public override double GetTotalSalary()
        {
            return base.GetTotalSalary() + share * 1000000;
        }

        public override string ToString()
        {
            return $"Top Manager: {name}, ${GetTotalSalary()}, {Age} y.o., ----> {numberOfSubordinates} sub. | company share: {share}%";
        }
    }
}
