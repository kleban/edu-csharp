using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Hello");
arrayList.Add(3.14);
arrayList.Add(true);



foreach (var item in arrayList)
{
    if(item is int)
        Console.WriteLine(item);
}
