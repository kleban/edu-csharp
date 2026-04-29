// Написати програму, яка генерує 10 випадкових чисел від 0 до 10.

Random r = new Random();

for (int i = 0; i < 10; i++)
{
    int a = r.Next(0, 11);
    if(a % 2 == 0)
        Console.WriteLine($"> {a}");
    else
        Console.WriteLine(a);
}
