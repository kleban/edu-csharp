using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Interface
{
    public class IntArray
    {
        private int[] _array;
        public IntArray()
        {
            _array = new int[0];
        }

        public string GetItems()
        {
            return _array.Length > 0 ?  string.Join(", ", _array) : "Array is empty!";
        }

        public void Add(int item = 0)
        {
            // _array = {3, 2, 5}; //Length = 3
            int[] tmp = new int[_array.Length]; // {0, 0, 0}

            if(tmp.Length > 0)
                Array.Copy(_array, tmp, _array.Length); // tmp = {3, 2, 5};                                                        

            _array = new int[tmp.Length + 1]; // {0, 0, 0, 0}

            Array.Copy(tmp, _array, tmp.Length); // _array = {3, 2, 5, 0}

            _array[_array.Length - 1] = item;
        }
    }
}
