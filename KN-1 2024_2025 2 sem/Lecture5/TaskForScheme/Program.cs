/*Розробити алгоритм, який аналізує послідовність цілих чисел (введених користувачем) і
 * виконує такі дії:

- Підраховує кількість парних та непарних чисел.
- Визначає максимальне та мінімальне число.
- Обчислює суму всіх чисел.
- Завершує введення при введенні нуля (0), який не враховується в обчисленнях.*/

int even = 0, odd = 0, max = int.MinValue, min = int.MaxValue, sum = 0;
int number = 0;

do
{
    number = int.Parse(Console.ReadLine());
   
    if (number % 2 == 0)    
        even++;    
    else    
        odd++;

    if (number > max)
        max = number;

    if (number < min)
        min = number;

    sum += number;

} while (number != 0);

Console.WriteLine($"Even: {even}");
Console.WriteLine($"Odd: {odd}");
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
Console.WriteLine($"Sum: {sum}");



