using System.Collections;

ArrayList alist = new ArrayList();
alist.Add("Hello");
alist.Add("World");
alist.Add(1);
alist.Add(2);
alist.Add(true);
alist.Add(new Student());

Object a = 10; // Boxing
int b = (int)a + 3; // Unboxing

Console.WriteLine(a.GetType());

foreach (var item in alist)
{
    Console.WriteLine(item);
}


class Student { }
