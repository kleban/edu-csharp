//Дано катети прямокутного трикутника (вводяться з клавіатури користувачем).
//Визначити довжину гіпотенузи.

Console.Write("Input a:\t");
int a = int.Parse(Console.ReadLine());
Console.Write("Input b:\t");
int b = int.Parse(Console.ReadLine());

double c = Math.Sqrt(a * a + b * b);

Console.WriteLine($"c = {c:0.00} sm");
