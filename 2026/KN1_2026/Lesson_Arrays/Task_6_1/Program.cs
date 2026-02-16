/* Задача 6.1
Написати програму, що знаходить суму парних та суму непарних елементів масиву.
Кількість елементів визначає користувач, 
елементи генеруються випадковим чином у діапазоні [10;100] (цілі числа).
*/

Console.Write("Input array size:\t");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

Random rand = new Random();

Console.Write("Array:\t");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10, 100);
    Console.Write($"{array[i]}\t");
}

int sum_p = 0, sum_np = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) 
        sum_p += array[i];
    else
        sum_np += array[i];
}
Console.WriteLine($"Sum p: {sum_p}, sum np: {sum_np}");