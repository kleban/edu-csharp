using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HR_App.Models
{
    public abstract class Worker
    {
        // fields
        protected string name;
        protected DateTime dateOfBirth;
        protected double salary;

        //ctor
        public Worker()
        {
            name = "-";
            dateOfBirth = new DateTime(1900, 1, 1);
            salary = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; } // read-only
            set
            {
                if (value >= 0)
                    salary = value;
            } // write-only
        }

        public double GetSalary() // getter, accessor
        {
            return salary;
        }

        public void SetSalary(double newSalary) // setter, mutator
        {
            if (newSalary >= 0)
                salary = newSalary;
        }



        public Worker(string n,
            DateTime dateOfBirth,
            double salary)
        {
            name = n;

            if (dateOfBirth.Year >= 1900)
                this.dateOfBirth = dateOfBirth;

            if (salary >= 0)
                this.salary = salary;
        }



        //methods
        public void PrintInfo()
        {
            Console.WriteLine($"This is worker with ${salary} salary!");
        }

        public void PrintInfo(bool name, bool date, bool salary)
        {
            string str = "";
            if (name)
                str += $"Name: {this.name}.\t";
            if (date)
                str += $"Date of Birth: {dateOfBirth.ToString("dd MMMM yyyy", new CultureInfo("uk-UA"))}.\t";
            if (salary)
                str += $"Salary: ${this.salary}.";

            Console.WriteLine(str);
        }

        public virtual string GetInfo()
        {
            string str = "";
            str += $"Name: {name}. ";
            str += $"Date of Birth: {dateOfBirth.ToString("dd MMMM yyyy", new CultureInfo("uk-UA"))}. ";
            str += $"Salary: ${GetFullSalary()}.";
            return str;
        }

        public abstract double GetFullSalary();

        public int GetAge()
        {
            var age = (int)(DateTime.Now - dateOfBirth).TotalDays / 365;
            return age;
        }


    }
}
