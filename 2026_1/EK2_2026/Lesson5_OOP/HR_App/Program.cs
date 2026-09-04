
using HR_App.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Worker[] workers = new Worker[4];

workers[0] = new Manager("Ivan Petrenko",
    new DateTime(1988, 4,1),
    2000, 25);

workers[1] = new SalesPerson("Olha Ivanenko",
    new DateTime(2000, 4, 3),
    2000,
    1200.20);

workers[2] = new Manager("Petro Stepanenko",
    new DateTime(1955, 4, 9),
    2000,
    17);

workers[3] = new TopManager("Olena Ivanenko",
    new DateTime(1990, 4, 2),
    2000, 78, 0.02);

//w.PrintInfo();
//w.PrintInfo(true, true, true);

//double sum_salary = 0;
//double sum_full_salary = 0;

foreach (var worker in workers)
{
    //Console.WriteLine($"${worker.Salary}\t${worker.GetFullSalary()}");
    // sum_salary += worker.Salary;
    // sum_full_salary += worker.GetFullSalary();
    Console.WriteLine(worker.GetInfo());
}

//Console.WriteLine("--------------------");
//Console.WriteLine($"${sum_salary}\t${sum_full_salary}");