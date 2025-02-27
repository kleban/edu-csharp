
int sum = 0;

for (int i = 0, j = 1; sum < 20; i++, j += 2)
{
    sum += i + j;
    Console.WriteLine("i:\t" + i + "\tj:\t" + j + "\tsum:\t" + sum);
}

Console.WriteLine(sum);