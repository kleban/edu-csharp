
Console.WriteLine("How many items copy?");
int count = int.Parse(Console.ReadLine());

int[] a = { 4, 2, 7, 3, 6, 7, 5, 2, 1, 5, 9 };

int[] b = new int[count];

Array.Copy(a, b, count);
Console.WriteLine();
Array.ForEach(b, Console.WriteLine);

