using ExamGeneartorApp.Data;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var taskGenerator = new ExamTasksGenerator(ExamQuestions.GetQuestions());
var tasks = taskGenerator.GetTasks(10);
var students = new StudentsGenertor().Get(10);
var results = ExamTasksGenerator.SetTasksForStudents(tasks, students);

Console.WriteLine("STOP");
Array.ForEach(results, x => Console.WriteLine(x));

Array.ForEach(taskGenerator.QC, x => Console.WriteLine(x));
Console.WriteLine("--------------------");
Array.ForEach(tasks, x => Console.WriteLine(x));
Array.ForEach(students, x => Console.WriteLine(x));




