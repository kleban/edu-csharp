using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Manager : Worker
    {
        protected int countOfw;
        public Manager(string name, int age, double salary, double bonus, int countOfw)
            : base(name, age, salary, bonus)
        {
            this.countOfw = countOfw;
        }

        public int CountOfW { get { return countOfw; } }

        public override string GetInfo()
        {
            return "Manager Info";
        }
        public override double GetFullSalary()
        {
            return base.GetFullSalary() + countOfw*1000;
        }

        public override string ToString()
        {
            return $"Manager: {name}, ${GetFullSalary()} ({age} y.o), workers: {countOfw}.";
        }
    }
}
