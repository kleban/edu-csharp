using OOPDemo1;

Worker worker = new Worker("John", 45, 2500);
worker.SetSalary(3000);
worker.SetBonus(0.1);
Console.WriteLine(worker.GetTotalSalary());
Console.WriteLine("----------------");
Manager m = new Manager();
m.SetSalary(5000);
Console.WriteLine(m);
Console.WriteLine("-----------");
TopManager topManager = new TopManager("Tom", 50, 10000, 10, 0.02);
Console.WriteLine(topManager);

