using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemoApp
{
    public class SalesPerson : Worker
    {
        private double sales_amount;

        public SalesPerson(string name, int age, double salary, double sales)
            : this(name, age, salary)
        {
            sales_amount = sales;
        }

        public SalesPerson(string name, int age, double salary) : base(name, age, salary)
        {
        }

        public override double GetSalary()
        {
            return sales_amount * 0.1 + base.GetSalary();
        }

        public override string GetInfo()
        {
            return $"Sales Person: {name}, ${GetSalary()}, sales: ${sales_amount}";
        }
    }
}
