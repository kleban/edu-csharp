
Random rand = new Random();

int min = int.MaxValue;

for(int i = 0; i < 10; i++)
{
    int num = rand.Next(10, 100);
    Console.Write($"{num} ");
    min = min > num ? num : min;
}

Console.WriteLine($"\nMin\t{min}");