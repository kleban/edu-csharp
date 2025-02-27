

/*for (ініціалізація; умова; інструкції)
{
    // тіло циклу
}*/

// for (;;);

int sum = 0;
for (int i = 1; i <= 10; i++)
{    
    sum += i;
    Console.WriteLine("i:\t" + i + "\tsum:\t" + sum);
}
Console.WriteLine(sum);