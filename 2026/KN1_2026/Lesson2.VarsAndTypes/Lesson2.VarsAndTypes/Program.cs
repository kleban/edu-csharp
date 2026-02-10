
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть b: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(a * a + b * b);

Console.WriteLine("Катет1: " + b + ", Катет2: " + a + ", Гіпотенуза: " + Math.Round(c, 2));
string result = string.Format("Катет1: {1}, Катет2: {0}, Гіпотенуза: {2:0.00}", a, b, c);
Console.WriteLine(result);

Console.WriteLine($"Катет1: {b}, Катет2: {a}, Гіпотенуза: {c:f2}");

//const

const string expected = "Expected value";

int x = 10;
x += 10;
x -= 4;
x *= 2;
x %= 3;


