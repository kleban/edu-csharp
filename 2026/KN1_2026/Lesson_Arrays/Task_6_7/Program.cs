double[] array = { -3, -5, 7, 9.3, -0.4, -3.7, 5.4, 9.7, -12 };

Console.WriteLine("Initial array:\t");
foreach (var i in array)
    Console.Write($"{i}\t");

// > 0 at the start, 0 <= at the end 

for (int i = 0; i < array.Length - 1; i++)
    for (int j = 0; j < array.Length - 1; j++)
        if (array[j] < 0 && array[j + 1] >= 0)
            (array[j], array[j + 1]) = (array[j + 1], array[j]);

Console.WriteLine("\n\nOutput array:\t");
foreach (var i in array)
    Console.Write($"{i}\t");