using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemoApp
{
    public class TopManager : Manager
    {
        protected double company_share;

        public TopManager(string name, int age, double salary, int workers, double share)
            : this(name, age, salary, workers)
        {
            company_share = share;
        }

        public TopManager(string name, int age, double salary, int workers) : base(name, age, salary, workers)
        {
        }
    }
}
