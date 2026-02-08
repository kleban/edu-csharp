using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemoApp
{
    public class Manager : Worker
    {
        protected int count_workers;

        public Manager(string name, int age, double salary, int workers)
            : this(name, age, salary)
        {
            count_workers = workers;
        }

        public Manager(string name, int age, double salary) 
            : base(name, age, salary)  {}

        public override double GetSalary()
        {
            return Math.Round(salary + count_workers*20);
        }

        public override string GetInfo()
        {
            return $"Manager: {name}, ${GetSalary()}, workers: {count_workers}";
        }

        public override double GetSalary()
        {
            return base.GetSalary() + count_workers * 120;
        }

        public override string GetInfo()
        {
            return $"Manager: {name}, ${GetSalary()}, workers: ${count_workers}";
        }
    }
}
