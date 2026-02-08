

using ListDemo.SortDemo;

var students = StudentsGenrator.GenerateStudents(10);

Console.WriteLine("---- Before sorting:");
students.ForEach(Console.WriteLine);

Console.WriteLine("---- After sorting:");
students.Sort(new StudentGradeComparer());
students.ForEach(Console.WriteLine);