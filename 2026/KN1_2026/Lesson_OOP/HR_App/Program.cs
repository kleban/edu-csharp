using HR_App.Models;

//Worker.company = "Adidas";

////Worker w1 = new Worker(
////    name: "Ivan Petrenko", 
////    age: 55, 
////    salary: 2300);

//Worker w1 = new Worker("Ivan");

//w1.SetAge(44);
//w1.Salary = -45654.5;

//Console.WriteLine(w1.Salary);

//Worker1 w1 = new Worker1("sdfdf", 3434, 234234);

//Manager m = new Manager("Vasyl Ostapenko", 44, 3000, 10);
//Console.WriteLine(m.GetInfo());

Worker[] workers = new Worker[5];
workers[0] = new TopManager("Ivan Petrenko", 22, 2000, 30, 0.05);
workers[1] = new SalesPerson("Olha Stepanenko", 21, 2000, 200);
workers[2] = new TopManager("Andriy Ivanenko", 33, 2000, 100, 0.02);
workers[3] = new Manager("Olena Illienko", 31, 2000, 20);
workers[4] = new SalesPerson("Ruslan Rudenko", 26, 2000, 100);

foreach(var w in workers)
{

    if(w is Manager)
    {
        Manager m = (Manager)w;
        if (w is TopManager)
        {
            var tm = w as TopManager;
            Console.WriteLine($"TM W: {tm.WorkersCount}, Share: {tm.GetCompanyShare()}%");
        }
        else
            Console.WriteLine($"M W: {m.WorkersCount}");
    }
        
}
