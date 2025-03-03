
//y = ((x + sin⁡(x))) /√(5 & x) + e ^ 4 +〖sin〗^2 (x+1)

for(int x = 1; x <= 10; x++)
{
    double y = (x + Math.Sin(x)) / Math.Pow(x, 1 / 5) + Math.Exp(4) + Math.Pow(Math.Sin(x + 1), 2);
    //double y = Math.Pow(x, 1 / 5.0);
    Console.WriteLine($"{x}\t{y:0.00}");
}