void PrintTable(string[] headers, string[][] rows, int[] widths)
{
    string sep = "+" + string.Join("+",
        widths.Select(w => new string('-', w + 2))) + "+";

    Console.WriteLine(sep); //top
    Console.WriteLine("|" + string.Join("|",
        headers.Select((h, i) => " " + h.PadRight(widths[i]) + " ")) + "|");
    Console.WriteLine(sep); //header

    foreach (var row in rows)
        Console.WriteLine("|" + string.Join("|",
            row.Select((c, i) => " " + c.PadRight(widths[i]) + " ")) + "|");

    Console.WriteLine(sep); //bottom
}

// Виклик:
PrintTable(
    new[] { "Продукт", "Кількість", "Ціна" },
    new[] {
        new[] { "Apple",  "12",  "45.00 ₴" },
        new[] { "Banana",  "5",  "22.50 ₴" },
        new[] { "Cherry","130",   "9.99 ₴" },
    },
    new[] { 20, 15, 10 }
);