
Random rand = new Random(2);

Console.WriteLine("--------------");
for(int i = 0; i < 10; i++)
{
    int a = rand.Next(100, 1000);
    Console.Write(a + "\t");
}
Console.WriteLine("\n--------------");
for (int i = 0; i < 10; i++)
{
    double a = rand.NextDouble();
    Console.Write("{0:0.00}\t", a);
}
Console.WriteLine("\n--------------");

Console.WriteLine(DateTime.Now.Ticks);