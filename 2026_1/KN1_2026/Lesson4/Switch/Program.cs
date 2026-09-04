//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.Write("Введіть номер пори року:\t");
//int num = int.Parse(Console.ReadLine());

//switch(num)
//{
//    case 1:
//        Console.WriteLine("Зима");
//        break;
//    case 2:
//        Console.WriteLine("Весна");
//        break;
//    case 3:
//        Console.WriteLine("Літо");
//        break;
//    case 4:
//        Console.WriteLine("Осінь");
//        break;
//    default:
//        Console.WriteLine("Введіть значення з діапахону [1;4]");
//        break;
//}

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.Write("Введіть оцінку учня [1;12]:\t");
//int num = int.Parse(Console.ReadLine());

//switch (num)
//{
//    case 1:
//    case 2:
//    case 3:
//        Console.WriteLine("Низький рівень");
//        break;
//    case 4:
//    case 5:
//    case 6:
//        Console.WriteLine("Середній рівень");
//        break;
//    case 7:
//    case 8:
//    case 9:
//        Console.WriteLine("Достатній рівень");
//        break;
//    case 10:
//    case 11:
//    case 12:
//        Console.WriteLine("Високий рівень");
//        break;
//    default:
//        Console.WriteLine("Введіть значення з діапазону [1;12]");
//        break;
//}

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.Write("Введіть оцінку учня [1;12]:\t");
//int num = int.Parse(Console.ReadLine());

//switch (num)
//{
//    case 1:
//    case 2:
//    case 3:
//        Console.WriteLine("Низький рівень");
//        break;
//    case 4:
//    case 5:
//    case 6:
//        Console.WriteLine("Середній рівень");
//        break;
//    case 7:
//    case 8:
//    case 9:
//        Console.WriteLine("Достатній рівень");
//        break;
//    case 10:
//    case 11:
//    case 12:
//        Console.WriteLine("Високий рівень");
//        break;
//    default:
//        Console.WriteLine("Введіть значення з діапазону [1;12]");
//        break;
//}

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть оцінку учня [1;12]:\t");

if (int.TryParse(Console.ReadLine(), out int num))
{
    string result = num switch
    {
        >= 1 and <= 3 => "Низький рівень",
        >= 4 and <= 6 => "Середній рівень",
        >= 7 and <= 9 => "Достатній рівень",
        >= 10 and <= 12 => "Високий рівень",
        _ => "Введіть значення з діапазону [1;12]"
    };

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некоректне введення!");
}