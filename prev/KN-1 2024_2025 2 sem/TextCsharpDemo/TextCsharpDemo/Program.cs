
string text = "Це реч ення ви кори стовує невидимі пробіли між слова ми які не видно.";
//text = text.Replace(" ", "|"); 

foreach (char c in text)
{
    Console.WriteLine($"Символ: '{c}' \t Код: U+{((int)c):X4}");
}