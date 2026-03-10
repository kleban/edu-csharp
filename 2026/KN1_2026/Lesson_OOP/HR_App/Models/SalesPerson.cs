using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public class SalesPerson : Worker
    {
        private double salesAmount;

        public SalesPerson(string name, int age, double salary, double sales) : base(name, age, salary)
        {
            salesAmount = sales;
        }
        public override string GetInfo()
        {
            return "Sales Person" + base.GetInfo() + $", Sales Amount: ${salesAmount}";
        }

        public override double GetFullSalary()
        {
            return salary + salesAmount*0.2;
        }

        //public override string GetInfo()
       // {
       //     return $"Sales Person: {name}, {age} y.o., ${salary:f2}"; ;
        //}
    }
}
