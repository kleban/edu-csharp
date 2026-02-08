

List<int> ints = new List<int>();
ints = new();

ints.Add(1);
ints.AddRange([3, 4, 5, 3]);

ints.RemoveAll(i => i > 3);
ints.Insert(1, 2);



foreach (var item in ints)
{
    Console.WriteLine(item);
}