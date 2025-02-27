
int[] array = { 4, 5, 6, 7, 3, 4, 9 };

Array.Reverse(array);
Array.Sort(array);
Array.Resize(ref array, array.Length + 1);
array[^1] = 100;
//Array.Copy()
Console.WriteLine(string.Join(", ", array));