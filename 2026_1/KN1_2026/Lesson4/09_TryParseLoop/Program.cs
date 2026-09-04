int age;

while (true)
{
    Console.Write("\nInput age:\t");
    string input = Console.ReadLine();

    if (int.TryParse(input, out age))
    {
        if (age > 0 && age <= 110)
            break;
        else
            Console.WriteLine("Age must be between 1 and 110!");
    }
    else
        Console.WriteLine("Input error!");

}

Console.WriteLine($"Age is {age}!");
