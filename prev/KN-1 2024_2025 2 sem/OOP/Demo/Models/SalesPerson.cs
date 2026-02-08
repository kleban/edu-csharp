using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class SalesPerson : Worker
    {
        protected double sales;
        public SalesPerson(string name, int age, double salary, double bonus, double sales)
            : base(name, age, salary, bonus)
        {
            this.sales = sales;
        }
        public override double GetFullSalary()
        {
            return base.GetFullSalary() + sales * 0.15;
        }

        public override string GetInfo()
        {
            return "SalesPerson Info";
        }

        public override string ToString()
        {
            return $"SalesPerson: {name}, ${GetFullSalary()} ({age} y.o), sales: ${sales}.";
        }
    }
}
