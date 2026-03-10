
using Methods;

Counter c = new Counter(0, 6);
c++;
c++;
c++;

(int min, int max) = c.GetRange();

Console.WriteLine($"min: {min}, max: {max}");