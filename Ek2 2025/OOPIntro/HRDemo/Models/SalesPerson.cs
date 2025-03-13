using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDemo.Models
{
    public class SalesPerson : Worker
    {
        protected double salesAmount;
        public SalesPerson(string name, DateTime dob, double salary, double bonus, double sales = 0)
            : base(name, dob, salary, bonus)
        {
            salesAmount = sales;
        }

        public double SalesAmount
        {
            get { return salesAmount; }
            set
            {
                salesAmount = value;
            }
        }

        public override string GetInfo()
        {
            string info = $"****** Sales Person *******\n" +
               $"Name:\t{name}\nSalary:\t${GetTotalSalary()}\nAge:\t{Age} y.o.\nSales:\t${salesAmount}\n";
            return info;
        }

        public override double GetTotalSalary()
        {
            return salary + bonus + salesAmount * 0.1;
        }

        public override string ToString()
        {
            return $"Sales Person: {name}, ${GetTotalSalary()}, {Age} y.o., ----> ${salesAmount} sales amount";
        }
    }
}
