// find max in array

Console.Write("Input size:\t");
int size = int.Parse(Console.ReadLine());

int[] a = new int[size];
Random r = new Random();

for (int i = 0; i < a.Length; i++)
    Console.Write($"{a[i] = r.Next(0,100)}\t");

int max = int.MinValue;

for(int i = 0; i < a.Length; i++)
{
    if (a[i] > max)    
        max = a[i];    
}

Console.WriteLine($"\n-- Max: {max}\n");
