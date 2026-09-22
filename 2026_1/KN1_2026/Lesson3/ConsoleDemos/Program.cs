

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Write("Input number:\t");
Console.ResetColor();

double number;
if (!double.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Write("Input power:\t");
Console.ResetColor();

double power;
if (!double.TryParse(Console.ReadLine(), out power))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

double result = Math.Pow(number, power);
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{number}^{power}");
Console.ResetColor();
Console.Write(" = ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("{result}\n\n\n");
Console.ResetColor();

//result - yellow
//number та power - red

