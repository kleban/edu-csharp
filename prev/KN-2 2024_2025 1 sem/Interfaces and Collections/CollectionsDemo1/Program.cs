
using System.Collections;

int[] array = new int[1];

/*
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("2");
arrayList.Add(true);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
} */

// 
Stack stack = new Stack();
stack.Push(1);
stack.Push("2");
stack.Push(true);

// First In Last Out  -> 

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
try
{
    Console.WriteLine(stack.Pop());
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

// Queue
Console.WriteLine("QUEUE");
Queue queue = new Queue();
queue.Enqueue(1);
queue.Enqueue("2");
queue.Enqueue(true);

Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
queue.Dequeue();
