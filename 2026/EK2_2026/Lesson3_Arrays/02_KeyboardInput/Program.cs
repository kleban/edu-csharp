Console.Write("Input array size:\t");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("\n");
int[] array = new int[size];

for (int i = 0; i < array.Length; ++i)
{
    Console.Write($"Input number {i+1}:\t");
    array[i] = int.Parse(Console.ReadLine());

}

Console.WriteLine();