using HRDemo.Models;

//Worker w = new Worker("John", new DateTime(1980, 12, 23), 50000, 5000);
//Console.WriteLine(w);

Console.ForegroundColor = ConsoleColor.White;

Manager manager = new Manager("Alice", new DateTime(1970, 1, 1), 100000, 10000, 10);
SalesPerson sp = new SalesPerson("Bob", new DateTime(1990, 2, 2), 100000, 10000, 80000);
SalesPerson sp2 = new SalesPerson("John", new DateTime(1997, 2, 2), 70000, 1000, 20000);
Manager manager1 = new Manager("Charlie", new DateTime(1980, 3, 3), 80000, 8000, 8);
TopManager tm = new TopManager("Eve", new DateTime(1960, 3, 3), 100000, 10000, 10, 0.02);
Director d = new Director();

Worker[] workers = new Worker[] { manager, sp, manager1, sp2, tm };

foreach (Worker worker in workers)
{
    SalesPerson sp1 = worker as SalesPerson; // null
    //sp1.Salary = 100;
    if(sp1 is not null)
 //   if (worker is SalesPerson)
    {     
        //SalesPerson sp1 = (SalesPerson)worker;

        if (sp1.SalesAmount > 50000)
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
        Console.ForegroundColor = ConsoleColor.White;



    Console.WriteLine(worker.GetInfo());

    Console.ForegroundColor = ConsoleColor.White;
}


