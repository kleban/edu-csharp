
int[] array = { 4, 7, 1, 2, 1,9,3 };
Console.WriteLine("Initial array:");
PrintArray(array);

for(int i = 0; i < array.Length - 1; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int tmp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = tmp;
        }
    }
}

Console.WriteLine("Sorted array:");
PrintArray(array);


static void PrintArray(int[] arr)
{
    foreach (int item in arr)
        Console.Write($"{item}\t");
    Console.WriteLine("\n----------------------------");
}