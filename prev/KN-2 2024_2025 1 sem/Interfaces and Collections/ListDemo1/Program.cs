
using System.Collections.Generic;

List<int> list = new List<int>();

int[] array = new int[0];

Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    list.Add(rand.Next(1, 9));
   // Console.WriteLine("------------------------------");
   // Console.WriteLine($"List Count: {list.Count}");
   // Console.WriteLine($"List Capacity: {list.Capacity}");
}

Print(list);
//list.Remove(4);
//list.RemoveAt(1);
//list.RemoveAll(i => i % 2 == 0);
//list.RemoveRange(5, 3);
//Print(list);

list.All(x => x % 2 == 0);
list.Any(x => x % 2 == 0);

list.Count(x => x % 2 == 0);

list.Sort();
Print(list);


static void Print(List<int> list)
{
    Console.Write("List: ");
    foreach (int item in list)
        Console.Write($"\t{item}");
    Console.WriteLine();
}