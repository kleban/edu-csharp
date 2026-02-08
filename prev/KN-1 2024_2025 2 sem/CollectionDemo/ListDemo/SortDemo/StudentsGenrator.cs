using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.SortDemo
{
    public class StudentsGenrator
    {
        public static List<Student> GenerateStudents(int count)
        {
            var students = new List<Student>();
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                students.Add(new Student
                {
                    Name = $"Student {random.Next(1,10)}",
                    Age = random.Next(16, 50),
                    Grade = Math.Round(random.NextDouble() * 100, 2)
                });
            }
            return students;
        }
    }
}
