
while (true)
{
    Console.WriteLine("----- MENU -----");
    //Console.WriteLine("1 - Plus");
    //Console.WriteLine("2 - Minus");
    //Console.WriteLine("[P]lus");
    Console.Write("Choose operator: + - * / ^ %\n");
    Console.Write("E[x]it\n\t\t\t:>\t");

    string input = Console.ReadLine();

    Console.Write("Input A:\t");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Input B:\t");
    int b = int.Parse(Console.ReadLine());

    double result = 0;
    bool validInput = true;

    switch (input)
    {
        case "+":
            result = a + b;
            break;
        case "-":
            result = a - b;
            break;
        case "x":
        case "X":
            return;
            break;
        default:
            validInput = false;
            Console.WriteLine("Input error!");
            break;
    }

    if (validInput)
        Console.WriteLine($"Result: {result}");
}
