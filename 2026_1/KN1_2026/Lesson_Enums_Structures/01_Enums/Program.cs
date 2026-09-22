using _01_Enums;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Input day of week [mon, tue, wed]:\t");
string input = Console.ReadLine();

Days day = Enum.Parse<Days>(input, ignoreCase: true);

switch (day)
{
    case Days.Mon:
        Console.WriteLine("Понеділок");
        break;
    case Days.Tue:
        Console.WriteLine("Вівторок");
        break;
    case Days.Wed:
        Console.WriteLine("Середа");
        break;
    case Days.Thu:
        Console.WriteLine("Четвер");
        break;
    case Days.Fri:
        Console.WriteLine("Пятниця");
        break;
    case Days.Sat:
        Console.WriteLine("Субота");
        break;
    case Days.Sun:
        Console.WriteLine("Неділя");
        break;
}

int int_day = (int)Days.Wed;

Console.WriteLine(int_day);
