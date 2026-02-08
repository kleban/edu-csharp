Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Якого розміру буде масив? \t >\t");
int n = int.Parse(Console.ReadLine());

int[] a = new int[n];
Random r = new Random();

for (int i = 0; i < a.Length; i++)
    a[i] = r.Next(1, 7);

Console.WriteLine(string.Join('\t', a));
int sum = 0;

int max = int.MinValue;

foreach(int i in a)
{
    sum += i % 2 == 0 ? i : 0;
    max = i > max ? i : max;
}

Console.WriteLine($"Сума парних: {sum}");
Console.WriteLine($"Максимальний елемент: {max}");
