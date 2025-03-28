using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class TopManager : Manager
    {
        protected double share = 0;
        public TopManager(string name, int age, double salary, 
            double bonus, int countOfw, double share)
            : base(name, age, salary, bonus, countOfw)
        {
            this.share = share;
        }
        public override double GetFullSalary()
        {
            return base.GetFullSalary() + share * 10000;
        }
        public override string ToString()
        {
            return $"TopManager: {name}, ${GetFullSalary()} ({age} y.o), workers: {countOfw}, share: {share *100}%.";
        }
    }
}
