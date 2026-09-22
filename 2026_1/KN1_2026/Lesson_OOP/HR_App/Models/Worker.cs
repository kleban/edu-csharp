using System;
using System.Collections.Generic;
using System.Text;

namespace HR_App.Models
{
    public abstract class Worker
    {
        //fields
        protected string name;
        protected int age;
        protected double salary;

        public static string company;

        //ctors
        public Worker() : this("empty", 0, 0)
        {
           // Console.WriteLine("Default Ctor");

        }

        public Worker(string name) : this(name, 0, 0)
        {
            //Console.WriteLine("3rd Ctor");
        }

        public Worker(string name, int age, double salary)
        {
            this.name = name;

            if (age >= 0 & age < 120)
                this.age = age;

            this.salary = salary;
            //Console.WriteLine("2nd Ctor");
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if (age >= 0 & age < 120)
                this.age = age;
        }

        public double GetSalary() // getter, accessor
        {
            
            return salary;
        }

        public void SetSalary(double newSalary) //setter, mutator
        {
            if (newSalary >= 0)
                salary = newSalary;
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                    salary = value;
            }
        }

        //methods
        public virtual string GetInfo()
        {
            return $": {name}, {age} y.o., ${GetFullSalary():f2}";
        }

        public string GetCompany()
        {
            return company;
        }

        public void SetCompany(string newCompany)
        {
            company = newCompany;
        }

        public abstract double GetFullSalary();        


    }
}
