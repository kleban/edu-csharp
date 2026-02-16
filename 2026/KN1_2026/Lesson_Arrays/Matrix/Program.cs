
//int[,] array;

//int[,] matrix1 = new int[3, 4];
//int[,] matrix2 = { { 3, 5, 6 }, { 3, 2, 1 } };

int rows = 3, cols = 4;
int[,] matrix = FillArrayRandom(rows, cols);
PrintMatrix(matrix);


static void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Matrix:");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

static int[,] FillArrayRandom(int r, int c)
{
    int[,] array = new int[r, c];
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10, 100);            
        }        
    }
    return array;
}