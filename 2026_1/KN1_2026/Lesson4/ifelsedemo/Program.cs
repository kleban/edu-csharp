
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Input number:\t");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("парне");
    Console.WriteLine("additional text");
}
else
    Console.WriteLine("непарне");