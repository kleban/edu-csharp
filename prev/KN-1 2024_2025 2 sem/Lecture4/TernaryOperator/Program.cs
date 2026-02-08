
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Write("Введіть число для перевірки:\t");
int a = int.Parse(Console.ReadLine());

string result = a % 2 == 0 ? "парне" : "непарне";

Console.WriteLine(result);

