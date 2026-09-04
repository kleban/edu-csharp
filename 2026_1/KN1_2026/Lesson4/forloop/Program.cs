
//for (; ; );


//for(int i = 0; i < 10 & i % 2 == 0; i++)

int sum = 0;

//for (int i = 0; i <= 10; i++)
//    sum += i;

//int i = 0;
//for (; i <= 10; i++)
//    sum += i;

//for (int i = 0; i <= 10; sum += i++) ;

//int sum = 0;
//for (int i = 0, j = 1; sum < 20; i++, j += 2)
//{
//    sum += i + j;
//}

//Console.WriteLine(sum);

for (int i = 0; i < 10; i++)
{
    if (i % 3 == 0) 
        continue;

    Console.Write($"{i}\t");

    if (i % 7 == 0)
        break;
}