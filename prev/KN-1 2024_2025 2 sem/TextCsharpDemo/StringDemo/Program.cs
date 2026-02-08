string text = "\"Hello, world!\" she exclaimed—excitedly. The meeting is " +
    "set for 3:45 p.m. on April 23rd, 2025. Please remember to " +
    "bring a notebook $55.9 (A5 size), a pen & pencil, a USB drive (≥16GB)," +
    " and an ID card with a photo! The total budget is $299.99." +
    " (including tax @ 7.5%). $3434.43 The temperature is expected to " +
    "be around 23°C ± 2°C. According to $45 the famous equation E =" +
    " mc², mass and energy are equivalent. $5667";

int start_index = 0;
while (true)
{
    var dollar_index = text.IndexOf("$", start_index);
    if (dollar_index == -1)
    {
        break; 
    }
    var space_after_dollar = text.IndexOf(" ", dollar_index);
    var dollar_data = text.Substring(dollar_index, space_after_dollar - dollar_index);
    Console.WriteLine(dollar_data);
    start_index = space_after_dollar;
}