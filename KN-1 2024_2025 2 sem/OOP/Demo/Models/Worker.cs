using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public abstract class Worker
    {
        // Fields
        protected string name;
        protected int age;
        protected double salary;
        protected double bonus;
        protected SocialPackage socialPackage;

        // Constructors
        public Worker():this("-", 0, 0)
        {
        }
        public Worker(string name)
        {
            this.name = name;
        }
        public Worker(string name, int age, double salary)
            : this(name)
        {
            if (age > 0 && age <= 100)
                this.age = age;
            this.salary = salary;
        }
        public Worker(string name, int age, double salary, SocialPackage pack, double bonus = 0)
            : this(name, age, salary)
        {            
            socialPackage = pack;
            this.bonus = bonus;
        }

        // Methods
        public double GetSalary() // getter // accessor
        {
            return salary;
        }

        public void SetSalary(double salary) // setter // mutator
        {
            if (salary > 0)
                this.salary = salary;
        }

        public abstract string GetInfo();
        public virtual double GetFullSalary()
        {
            return salary * (1 + bonus);
        }

        public double Salary
        {
            get 
            {
                return salary;
            }
            set 
            {
                if (value > 0)
                    salary = value;
            }
        }
 
        public override string ToString()
        {
            return $"Worker: {name}, ${GetFullSalary()} ({age} y.o)";
        }

    }
}
