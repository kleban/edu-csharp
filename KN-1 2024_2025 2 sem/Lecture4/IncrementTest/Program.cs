
int a = 1, b = 1;
int c = a++; // c = 1, a = 2
c += ++b - a--; // b = 2, a = 1

Console.WriteLine(a + b + c);

// 4