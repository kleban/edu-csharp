using System.Collections;
using ArrayListDemo;

ArrayList alist = new ArrayList(); // Capacity = 8
//alist.Count();
alist.Add("Hello");
alist.Add(456);
alist.Add(3.14);
alist.Add(true);
alist.Add(new Person("John", 30)); // Capacity = 16

//alist.Capacity = 10; // Set capacity to 10


int a = 10;
object objA = a; // Boxing

int b = (int)objA; // Unboxing

foreach (var item in alist)
{
    if(item is int)
        Console.WriteLine(Math.Pow((int)item,2));
}


