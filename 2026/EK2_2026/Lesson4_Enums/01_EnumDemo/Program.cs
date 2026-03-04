using _01_EnumDemo;

Day day = Day.Wed;

switch (day)
{
    case Day.Mon:
    case Day.Tue:
    case Day.Wed:
    case Day.Thu:
    case Day.Fri:
        Console.WriteLine("Working!");
        break;
    case Day.Sat:
    case Day.Sun:
        Console.WriteLine("Weekend!");
        break;
}