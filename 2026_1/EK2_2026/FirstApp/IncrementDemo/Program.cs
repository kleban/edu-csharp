
//int x = 1, y = 2;
//int c = x++ - y--; // y = 2, x = 1, c = -1
//// y = 1, x = 2
//Console.WriteLine(c + x + y); // -1 + 1 + 2 = 4  

//int a = 2, b = 3;
//int c = ++a - b--; // a = 3, b = 3, c = 0;
//// a = 3, b = 2, c = 0
//Console.WriteLine(c + a + b); // ?? 1, 5, 5, 2, 1

int a = 0, b = 4;
int c = a++ + ++b; // a = 0; b = 5; c = 5
// a = 1, c = 5, b = 5;
c = c + b - --a; // 5 + 5 + 0// a = 0
Console.WriteLine(c + a + b); // 15, 11, 15, 15

//// ++x - prefix // x++ - posfix
//Console.WriteLine(++x);
//Console.WriteLine(x);