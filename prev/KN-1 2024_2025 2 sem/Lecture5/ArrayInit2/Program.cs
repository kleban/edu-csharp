
Console.Write("Якого розміру буде масив? \t >\t");
int n = int.Parse(Console.ReadLine());

int[] a = new int[n];
Random r = new Random();

for (int i = 0; i <= a.Length; i++)
{
    Console.Write($"Введи {i+1}:\t");
    a[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n" + string.Join('\t', a));
