using System.Collections;

Queue queue = new Queue();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue("sdsdfsdf");

Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());

/*Stack stack = new Stack();
stack.Push(3);
stack.Push(4);
stack.Push("sdfsdfsdf");

Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());

foreach (var item in stack)
{
    Console.WriteLine(item);
}*/