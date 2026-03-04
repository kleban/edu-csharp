
Console.Write("Input number:\t");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Winter");
        break;
    case 2:
        Console.WriteLine("Spring");
        break;
    case 3:
        Console.WriteLine("Summer");
        break;
    case 4:
        Console.WriteLine("Autumn");
        break;
    default:
        Console.WriteLine("Error!");
        break;
}
