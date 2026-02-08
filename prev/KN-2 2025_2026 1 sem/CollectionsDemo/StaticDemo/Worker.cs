using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Worker
    {
        private static int workerCount = 0;
        public Worker()
        {
            workerCount++;
        }
        public string Name { get; set; }
        public double Salary { get; set; }

        public static int GetWorkerCount()
        {
            return workerCount;
        }

        public void IncreaseCount(int count)
        {
            workerCount += count;
        }
    }
}
