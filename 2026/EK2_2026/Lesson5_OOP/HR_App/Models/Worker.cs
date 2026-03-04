using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public class Worker
    {
        public string name;
        public int age;
        private double salary;

        public void PrintInfo()
        {
            Console.WriteLine($"This is worker with ${salary} salary!");
        }
    }
}
