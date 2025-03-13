using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDemo.Models
{
    public abstract class Worker
    {
        protected string name;
        protected DateTime dob;
        protected double salary;
        protected double bonus;

        public Worker(string name, DateTime dob, double salary, double bonus)
        {
            this.name = name;
            this.dob = dob;
            this.salary = salary;
            this.bonus = bonus;
        }

        public int Age
        {
            get { return (int)(DateTime.Now - dob).TotalDays/365; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (salary == value)
                    salary = value;
            }
        }

        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double salary)
        {
            if (salary >= 0)
                this.salary = salary;
        }

        public virtual double GetTotalSalary()
        {
            return salary + bonus;
        }

        public abstract string GetInfo();

        public override string ToString()
        {
            return $"Worker: {name}, ${GetTotalSalary()}, {Age} y.o.";
        }
    }
}
