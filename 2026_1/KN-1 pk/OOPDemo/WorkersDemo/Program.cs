using WorkersDemo.Models;

int a = 10;

Worker w1 = new Worker("John Doe", 22, 200);
Worker w2 = new Worker("Oleh Veselyi", -223, 1000);
Worker w3 = new Worker();

Console.WriteLine(w1.GetInfo());
Console.WriteLine(w2.GetInfo());
Console.WriteLine(w3.GetInfo());

Console.Write("\n Input Salary:\t");
double salary = Convert.ToDouble(Console.ReadLine());
//w3.SetSalary(salary);

w3.Salary = salary + 10;

double sum = w1.Salary + w2.GetSalary() + w3.GetSalary();

Console.WriteLine($"Total Salary: ${sum}");