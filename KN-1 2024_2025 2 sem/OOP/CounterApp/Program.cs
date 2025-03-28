
using CounterApp;

Counter c = new Counter(2,5);
//
while (true)
{
    Console.Write("\n[I]ncrement\n[C]urrent\nE[x]it:>\t");
    string choice = Console.ReadLine().ToLower();
    switch(choice)
    {
        case "i":
            c.Increment();
            break;
        case "c":
            Console.WriteLine($"Current: {c.Current}");
            break;
        case "x":
            return;
        default:
            Console.WriteLine("Wrong choise!");
            break;

    }
}
