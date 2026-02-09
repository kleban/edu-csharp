Console.Write("Input group name: ");
var name = Console.ReadLine();
Console.Write("Input group size: ");
int size = int.Parse(Console.ReadLine());

Console.WriteLine($"Group {name} has {size} members.");

Console.ReadKey();