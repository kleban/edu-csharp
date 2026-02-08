
using Demo.Models;
Worker worker = new Manager("Jane", 30, 10000, 0.2, 10);
Worker[] w = new Worker[4];
w[0] = worker;
w[1]  = new Manager("Jane", 30, 10000, 0.2, 10);
w[2] = new TopManager("Jack", 40, 10000, 0.2, 10, 0.03);
w[3] = new SalesPerson("Jill", 25, 10000, 0.2, 10000);

foreach(var wx in w)
{
    if (wx is Manager)
    {
        Console.WriteLine(wx);
    }
   
}
