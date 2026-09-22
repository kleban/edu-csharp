
int sum = 0;
int i = 11;

do
{
    sum += i;
    Console.WriteLine($"{i}). sum = {sum}");
    i++;
} while (i <= 10);

//while (i <= 10)
//{    
//    sum += i;
//    Console.WriteLine($"{i}). sum = {sum}");
//    i++;
//}

//for(int i = 1; i <= 10; i++)
//{
//    if (i % 7 == 0)
//        break;

//    if (i % 2 == 1)
//        continue;

//    sum = sum + i;
//    Console.WriteLine($"{i}). sum = {sum}");
//}

Console.WriteLine();
