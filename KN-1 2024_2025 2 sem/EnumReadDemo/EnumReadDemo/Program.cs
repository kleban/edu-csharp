using EnumReadDemo;

Console.Write("Input day:\t");
string input = Console.ReadLine(); // "Monday"
Day day = Enum.Parse<Day>(input, true); // "MONDAY", "monday"
Day day1 = (Day)Enum.Parse(typeof(Day), input);

Console.WriteLine(day);
Console.WriteLine("------------");
Console.Write("Input day number:\t");
int inputNumber = int.Parse(Console.ReadLine()); // 1
Day day2 = (Day)inputNumber;



