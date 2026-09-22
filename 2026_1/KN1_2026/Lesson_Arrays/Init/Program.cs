
//int[] a = new int[2];
//int[] b = new int[] { 3, 5, 2, 6, 7, 8 };
//int[] b1 = { 3, 5, 2, 6, 7, 8 }; // Literal array initialization
//string[] c = new string[] { "Hello", "World" };

//int[] array = new int[5];
//Random random = new Random();

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 10);
//    Console.Write($"{array[i]}\t");
//}

int[] array;
Console.Write("Input array size:\t");
int size = int.Parse(Console.ReadLine());

array = new int[size];

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Input element {i + 1}:\t");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nArray: ");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}\t");
Console.WriteLine();

