

int num = 0;

while (num < 1 || num > 4)
{
    Console.Write("Input number:\t");
    num = int.Parse(Console.ReadLine());
}

//do
//{
//    Console.Write("Input number:\t");
//    num = int.Parse(Console.ReadLine());
//}
//while (num < 1 || num > 4);


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


// for, while
// do-while
// foreach
