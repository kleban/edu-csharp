Console.Write("Введіть номер пори року [1;4]:\t");

int season = int.Parse(Console.ReadLine());

string result = season switch
{
    1 => "Зима",
    2 => "Весна",
    3 => "Літо",
    4 => "Осінь",
    _ => "Введіть номер пори року від 1 до 4"
};

Console.WriteLine(result);