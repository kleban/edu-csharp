using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Structure
{
    struct StudentGenerator
    {
        public Student[] GetStudents(int count) 
        {
            Student[] students = new Student[count];
            Random r = new Random();

            string[] cities = { "Ostroh", "Zdolbuniv", "Rivne", "Dubno" };

            for (int i = 0; i < students.Length; i++)
            {
                var date = new DateTime(r.Next(2005, 2010), r.Next(1, 13), r.Next(1, 29));
                students[i] = new Student(
                    name: $"Name{i + 1}",
                    date: date,
                    city: cities[r.Next(1, 4)],
                    year: r.Next(1, 5),
                    s: (Spec)r.Next(1, 5));
            }
            return students;
        }
    }
}
