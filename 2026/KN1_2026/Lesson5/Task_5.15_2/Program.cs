int cols = 12;
int rows = 5;

const string symbol = "*";

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
            Console.Write(symbol);
        else 
            Console.Write(" ");
    }
    Console.WriteLine();
}