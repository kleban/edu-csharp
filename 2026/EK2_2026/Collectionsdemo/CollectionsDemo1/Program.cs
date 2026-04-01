
using System.Collections;

//Stack stack = new Stack();
//stack.Push();
//stack.Pop();
//stack.Peek();

//Queue queue = new Queue();
//queue.Enqueue();
//queue.Dequeue();
//queue.Peek();

//Generic
//Stack<int> stack = new Stack<int>();
//Queue<string> que = new Queue<string>();

List<int> list = new List<int> { 1, 5, 2, 6, -6, -3, 7, 2, 1, 0, 9 };
list.All(t => t > 0 & t <= 10);
list.Any(t => t > 0);
var list2 = list.Distinct();
list.FirstOrDefault(x => x > 30 && x != 0);
//list.ForEach(Console.WriteLine);
list2 = list.FindAll(x => x % 2 == 0);
list2 = list.OrderByDescending(x => x);
list.Where(x => x > 3);
list.Select(x => x * 2);
Console.WriteLine(string.Join(", ", list2));
//list.Add(0);
//list.AddRange();
//list.Clear();
//list.Remove(0);
//list.RemoveAt(0);
//list.Average();
//list.Insert(5, 4);
//list.InsertRange(0, 5);
//list.Contains(5);
//list.Count();

