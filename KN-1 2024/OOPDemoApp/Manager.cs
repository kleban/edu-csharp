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

        public Manager(string name, int age, double salary) : base(name, age, salary)
        {
        }
    }
}
