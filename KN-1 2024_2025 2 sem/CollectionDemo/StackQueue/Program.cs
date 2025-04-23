using System.Collections;

Stack<int> stack = new Stack<int>();
stack.Push(1);
//stack.Push("dfsd");

Queue<decimal> d = new Queue<decimal>();
d.Enqueue(1.2m);
//d.Enqueue(3.4);

Queue<double> d1 = new Queue<double>();
d1.Enqueue(1);
d1.Enqueue(3.4);
d1.Enqueue(3L);


/*Queue queue = new Queue();
queue.Enqueue(1);
queue.Dequeue();
queue.Peek();*/

/*
Stack stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push("674");
stack.Push(13);
stack.Push("2sdfsdfw");
stack.Push(12);
stack.Push("2w");
var obj = stack.Pop();
stack.Peek();
stack.Peek();
stack.Pop();
stack.Peek();

foreach(var s in stack)
    Console.WriteLine(s);*/