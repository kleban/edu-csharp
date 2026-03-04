
int[,] matrix = new int[3, 5];
//int[,] m2 = { { 2, 3, 4 }, { 4, 2, 1 } };

Random r = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = r.Next(10, 100);
        Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
