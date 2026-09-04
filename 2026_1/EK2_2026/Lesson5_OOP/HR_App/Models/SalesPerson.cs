using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public class SalesPerson : Worker
    {
        private double salesAmount;

        public SalesPerson(string name,
            DateTime dob,
            double salary,
            double sales) : base(name, dob, salary)
        {
            salesAmount = salary;
        }

        public override double GetFullSalary()
        {
            return salary + salesAmount*0.1;
        }

        public override string GetInfo()
        {
            string str = "Sales Person: ";
            str += base.GetInfo();
            str += $"Sales: ${salesAmount:f2}.";
            return str;
        }
    }
}
