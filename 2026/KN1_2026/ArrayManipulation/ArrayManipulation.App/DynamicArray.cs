using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayManipulation.App
{
    struct DynamicArray
    {
        int[] array;

        public DynamicArray(int count)
        {
            array = new int[count];
            for(int i = 0; i <array.Length; i++)
                array[i] = new Random().Next(10,100);
        }

        public int[] GetArray()
        {
            return array;
        }

        public void Add(int value)
        {
            Array.Resize<int>(ref array, array.Length + 1);
            array[^1] = value;
        }

        public void Remove(int index)
        {
            int[] tmp = new int[array.Length - 1];
            Array.Copy(array, 0, tmp, 0, index);
            Array.Copy(array, index + 1, tmp, index, array.Length - 1 - index);
            array = tmp;
        }
    }
}
