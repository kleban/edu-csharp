using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGeneartorApp.Data
{
    public class StudentTaskGrade
    {
        private Student student;
        private ExamTask task;
        private double grade;

        public StudentTaskGrade(Student student, ExamTask task)
        {
            this.student = student;
            this.task = task;
            grade = 0;
        }
        public ExamTask Task { get { return task; } }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override string ToString()
        {
            return $"{student.Name} ({task.Variant}): {Grade}";
        }
    }
}
