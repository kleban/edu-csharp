

using System.Globalization;

double a = 10;
int b = 7;

Console.WriteLine("1 - {0}", a/b);
Console.WriteLine("2 - {0:f4}", a / b);

Console.WriteLine($"3 - {(a/b).ToString("0.000")}");
Console.WriteLine($"4 - {(a / b).ToString("0.###")}");

Console.WriteLine($"5 - {(a / b):0.000}");
Console.WriteLine($"6 - {(a / b):00.###}");

Console.WriteLine("7 - {0:c}", a / b);

Console.WriteLine("7 - {0:p}", a / b);

Console.WriteLine(34.ToString("D3"));


// Напишіть програму, що на основі введеної інформації про кількість хвилин
// проведення деякої події виводить на екран цю інформацію у форматі
// год:хв, наприклад
// 120 → 02:00
// 5 → 00:05
// 70 → 01:10