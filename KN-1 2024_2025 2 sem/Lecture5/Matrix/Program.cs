
int[,] array = new int[3, 4];

Random r = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
	for (int j = 0; j < array.GetLength(1); j++)
	{
		array[i, j] = r.Next(10, 20);
	}
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
