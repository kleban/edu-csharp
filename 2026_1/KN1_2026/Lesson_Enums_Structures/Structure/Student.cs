using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Structure
{
    struct Student
    {
        //Feild
        public string name;
        public DateTime dateOfBirth;
        public string city;
        public int year;
        public Spec spec;

        //Ctor
        public Student(string name, DateTime date, string city, int year, Spec s)
        {
            this.name = name;
            dateOfBirth = date;
            this.year = year;
            this.city = city;
            this.spec = s;
        }

        public int GetAge()
        {
            return getAge();
        }

        private int getAge()
        {
            var age = (DateTime.Now - dateOfBirth).TotalDays/365;
            return (int)age;
        }

        //Methods
        public string GetInfo()
        {
            string str = "\tДОВІДКА\nпідтверджує, що\n" 
                + $"{name} ({getAge()}) дійсно навчається на {year} курсі\n"
                +$"спеціальності {spec}\n\n";
            return str;
        }

        public override string ToString()
        {
            return $"{name}, ({getAge()}) - {city}";
        }
    }
}