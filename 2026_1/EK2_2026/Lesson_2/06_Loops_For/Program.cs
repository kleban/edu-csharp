
int sum = 0;

//for(int i = 0; i <= 10; i++)
//{
//    sum = sum + i;
//}

//for (int i = 0; i <= 10; i++)
//    sum += i;

//for (int i = 0; i <= 10;)
//    sum += i++;

//int i = 0;
//for (; i <= 10;)
//    sum += i++;


//for (int i = 0; i <= 10; sum += i++) ;

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);

    if (i % 2 == 1)
        continue;

    if (i % 8 == 0)
        break;

    sum = sum + i;
}

Console.WriteLine("Sum " + sum);
