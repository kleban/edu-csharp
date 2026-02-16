
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Який символ потрібно виводити?\t:>\t");
string symbol = Console.ReadLine();

Console.Write("Скільки символів виводити?\t:>\t");
int length = int.Parse(Console.ReadLine());

Console.Write("Вивести горизонально [h] чи вертикально [будь-який символ]?\t:>\t");
string direction = Console.ReadLine();

for(int i = 1; i <= length; i++)
{
    string output = $"{symbol}";
    if (direction != "h")
        output += "\n";
    Console.Write(output);
    
}
Console.WriteLine("\n\n\n");
