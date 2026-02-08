using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGeneartorApp.Data
{
    public class StudentsGenertor
    {
        Random rnd = new Random();
        public Student[] Get(int count)
        {
            var _idStart = rnd.Next(1000, 8000);

            var students = new Student[count];

            for (int i = 0; i < count; i++)
            {
                students[i] = new Student(_idStart + i, $"Student {i + 1}");
            }

            return students;
        }
    }
}
