using System;
using System.Collections.Generic;
using System.Text;

namespace WorkersDemo.Models
{
    public class Worker
    {
        private string name;
        private int age;
        private double salary;

        public Worker() : this("Unknown", 18)
        {
        }

        // 100,000
        public Worker(string name, int age)
        {           
            this.name = name;

            if (age >= 18 && age < 100)
                this.age = age;
        }

        public Worker(string name, int age, double salary) 
            : this(name, age)
        {           
            SetSalary(salary);
        }

        //Methods
        public double GetSalary() // getter, accessor
        {
            return salary;
        }

        public void SetSalary(double newSalary) // setter, mutator
        {
            if (newSalary >= 0)
                salary = newSalary;
        }

        //Property
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
            }
        }


        public string GetInfo()
        {
            string info = $"Name: {name}, Age: {age}, Salary ${salary}";
            return info;
        }
    }
}
