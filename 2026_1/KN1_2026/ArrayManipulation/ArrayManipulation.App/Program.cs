// Navigation
// Print
// Add
// Delete
// Insert
// Edit

using ArrayManipulation.App;

var array = new DynamicArray(10);

while (true)
{
    ShowNavigaion();
    string choice = Console.ReadLine();

    Console.Clear();

    switch (choice)
    {
        case "p":
        case "P":
            Print(array.GetArray());
            break;
        case "a":
        case "A":
            Console.Write("Input new item:\t");
            int newItem = int.Parse(Console.ReadLine());
            array.Add(newItem);
            Console.WriteLine("Item added successful\n");
            break;
        case "r":
        case "R":
            Console.Write("Input index of the item to remove:\t");
            int index = int.Parse(Console.ReadLine());
            array.Remove(index);
            Console.WriteLine("Item removed\n");
            break;
    }

}

//while(true)
//{
//    ShowNavigaion();
//    string choice = Console.ReadLine();

//    Console.Clear();

//    switch (choice)
//    {
//        case "p":
//        case "P":
//            Print(array);
//            break;
//        case "a":
//        case "A":
//            Console.Write("Input new item:\t");
//            int newItem = int.Parse(Console.ReadLine());
//            array = AddNewItemWithArray(array, newItem);
//            Console.WriteLine("Item added successful\n");
//            break;
//        case "r":
//        case "R":
//            Console.Write("Input index of the item to remove:\t");
//            int index = int.Parse(Console.ReadLine());

//            int[] tmp = new int[array.Length - 1];
//            Array.Copy(array, 0, tmp, 0, index);
//            Array.Copy(array, index + 1, tmp, index, array.Length - 1 - index); 
//            array = tmp;
//            Console.WriteLine("Item removed\n");
//            break;
//    }

//}

static void ShowNavigaion()
{
    Console.WriteLine("--- Navigation --");
    Console.WriteLine("[P]rint array");
    Console.WriteLine("[A]dd item by index");
    Console.WriteLine("[R]emove item by index");
    Console.WriteLine("[I]nsert inter by index");
    Console.WriteLine("[E]dit item by index");
    Console.WriteLine("E[x]it");
    Console.Write("\t\t\t:>\t");
}

static void Print(int[] array)
{
    Console.WriteLine("-- Print array --");
    foreach(int i in array) 
        Console.Write($"{i}\t");
    Console.WriteLine("\n-----------------\n");    
}

static int[] AddNewItem(int[] source, int value)
{
    int[] dest = new int[source.Length + 1];

    for(int i=0; i < source.Length; i++)
        dest[i] = source[i];

    dest[^1] = value;

    return dest;
}
static int[] AddNewItemWithArray(int[] source, int value)
{
    Array.Resize<int>(ref source, source.Length + 1);
    source[^1] = value;
    return source;
}


