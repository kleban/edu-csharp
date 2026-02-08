
Console.Write("Введіть номер пори року [1;4]:\t");

int season = int.Parse(Console.ReadLine());

switch(season)
{
    case 1:
        Console.WriteLine("Зима");
        break;
    case 2:
        Console.WriteLine("Весна");
        break;
    case 3:
        Console.WriteLine("Літо");
        break;
    case 4:
        Console.WriteLine("Осінь");
        break;
    default:
        Console.WriteLine("Введіть номер пори року від 1 до 4");
        break;
}