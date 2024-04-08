using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemoApp
{
    public class Worker
    {
        // Fields
        protected string name;
        protected int age;
        protected double salary;


        public Worker(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        public Worker(string name, int age, double salalry) : this(name, age)
        {
            this.salary = salalry;
        }

        //Properties
        public double Salary
        {
            get { return salary; } 
            set 
            {
                if (value > 0 && value < 10000000)
                    salary = value;
            }
        }

        //Methods
        public double GetSalary() //getter
        {
            return salary;
        }

        public void SetSalary(double new_salary) // setter
        {
            if(new_salary > 0 && new_salary < 10000000)
                salary = new_salary;
        }

        /// <summary>
        /// Increase salary by percentage
        /// </summary>
        /// <param name="perc">from 0 to 1</param>
        public void IncSalary(double perc)
        {
            salary *= (1 + perc);
        }

        public string GetInfo()
        {
            return $"{name}, {age} years, ${salary}";
        }

    }
}
