using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDemo.Models
{
    public class Manager : Worker
    {
        protected int numberOfSubordinates;
        //ctor
        public Manager(string name, DateTime dob, double salary, 
            double bonus, int numberOfSubordinates) 
            : base(name, dob, salary, bonus)
        {
            this.numberOfSubordinates = numberOfSubordinates;
        }

        public override string GetInfo()
        {
           string info = $"****** Manager *******\n" +
                $"Name:\t{name}\nSalary:\t${GetTotalSalary()}\nAge:\t{Age} y.o.\nSubs.\t{numberOfSubordinates}\n";
           return info;
        }

        public override double GetTotalSalary()
        {
            return base.GetTotalSalary() + numberOfSubordinates*1000;
        }

        public override string ToString()
        {
            return $"Manager: {name}, ${GetTotalSalary()}, {Age} y.o., ----> {numberOfSubordinates} sub."; ;
        }
    }
}
