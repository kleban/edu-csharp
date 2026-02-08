
using System.Collections;

Stack stack = new Stack();

stack.Push(1);
stack.Push("Hello");
stack.Push(3.14);
stack.Push(true);
stack.Push('A');


stack.Push(100L);
stack.Push(2.5f);
stack.Push(300M);

stack.Pop();

stack.Peek();
