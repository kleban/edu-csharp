using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo1
{
    public class SalesPerson : Worker
    {
        private double sales = 0;
        public SalesPerson() : base()
        {
        }
        public SalesPerson(string name, int age, double salary, double percent, double sales)
            : base(name, age, salary)
        {
            this.sales = sales;
        }
        public override string ToString()
        {
            return $"SalesPerson: {name}: {age} years old, ${salary} ---> +++++ sales: ${sales}";
        }
       
    }
}
