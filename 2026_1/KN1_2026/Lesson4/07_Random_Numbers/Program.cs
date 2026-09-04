
//seed
Random rand = new Random(2026);

for (int i = 0; i < 10; i++)
{
    int num = rand.Next(10,20);
    Console.Write($"{num}\t");
}
