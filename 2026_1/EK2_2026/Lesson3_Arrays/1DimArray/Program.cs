
//int[] array;
//array = new int[4];

//double[] da = new double[7];

//int[] a = { 4, 7, 2, 1, 4, 5, 9 };

//a[4] = 0;
//int d = a[8];

Console.Write("Input array size:\t");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("\n");

int[] array = new int[size];

Random r = new Random();

for(int i = 0; i < array.Length; ++i)
{
    array[i] = r.Next(10,100);
    Console.Write($"{array[i]}\t");
}

Console.WriteLine();