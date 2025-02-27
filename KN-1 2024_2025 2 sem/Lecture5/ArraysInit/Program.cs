

//int[] a = { 2, 4, 5, 6, 7, 2};
//Console.WriteLine(string.Join('\t', a));

Console.Write("Якого розміру буде масив? \t >\t");
int n = int.Parse(Console.ReadLine());

int[] a = new int[n];
Random r = new Random();

for (int i = 0; i < a.Length; i++)
{
    a[i] = r.Next(10, 100);
}

Console.WriteLine(string.Join('\t', a));