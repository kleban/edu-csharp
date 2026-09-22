
int[] array = { 34, 46, 23, 56, 11, 33, 90 }; // 1001

int min = int.MaxValue;

foreach(int a in array)
{
    if(min > a)
    {
        min = a;
    }
}

Console.WriteLine($"Min: {min}");