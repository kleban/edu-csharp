using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public class Worker1(string name, int age, double salary)
    {
        private string name = name;
        private int age = age;
        private double salary = salary;

        public void Print()
        {
            Console.WriteLine($"Worker: {name}, {age} y.o., ${salary:f2}");
        }
    }
}
