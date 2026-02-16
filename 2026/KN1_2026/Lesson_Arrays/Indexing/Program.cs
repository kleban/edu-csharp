
int[] array = { 4, 7, 2, 2, 1, 1, 6, 7 };

PrintArray(array);

int a = array[6];
Console.WriteLine(a);

int last = array[array.Length - 1];
//int last1 = array[array.Length];

int lastByIndex = array[^1];
//Console.WriteLine(lastByIndex);

int lastByIndex2 = array[^2];
//Console.WriteLine(lastByIndex2);

//

int[] range = array[0..2];
PrintArray(range);

range = array[4..];
PrintArray(range);

range = array[^2..];
PrintArray(range);

Index index = ^2;
Range range1 = 2..^2;

static void PrintArray(int[] arr)
{
    foreach (int item in arr)
        Console.Write($"{item}\t");
    Console.WriteLine();
}

