
using System.Text;

StringBuilder stringBuilder = new StringBuilder();

for (int i = 0; i < 5; i++)
{
    var text = Console.ReadLine();
    stringBuilder.AppendFormat("{0}: {1}\n", i+1, text);
}

Console.WriteLine(stringBuilder.ToString());