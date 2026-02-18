// Name
// Age
// City
using _02_Structure;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var students = new StudentGenerator().GetStudents(50);

for (int i = 0; i < students.Length; i++)
    Console.WriteLine($"{i+1}. {students[i]}");

