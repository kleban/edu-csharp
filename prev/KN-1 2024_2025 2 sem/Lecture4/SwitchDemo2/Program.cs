
Console.Write("Введіть оцінку [1-12]:\t");
int res = int.Parse(Console.ReadLine());

switch(res)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("Низький рівень");
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine("Середній рівень");
        break;
}
