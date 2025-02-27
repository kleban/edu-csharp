
Console.Write("Enter min:\t");
int min = int.Parse(Console.ReadLine());
Console.Write("Enter max:\t");
int max = int.Parse(Console.ReadLine());

Random random = new Random(2025);

for (int i = 0; i < 10; i++)
{
    Console.Write(random.Next(min, max) + "\n");
}
Console.WriteLine("\n");