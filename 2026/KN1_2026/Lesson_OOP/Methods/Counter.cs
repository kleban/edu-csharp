using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Counter
    {
        private readonly int min;
        private readonly int max;
        private int current;

        public Counter(int min, int max = 5)
        {
            this.min = min;
            current = min;
            this.max = max;
        }

        public int Max { get { return max; } }
        public int Min { get { return min; } }

        public static Counter operator ++(Counter counter)
        {
            counter.Increment();
           return counter;
        } 

        public (int,int) GetRange()
        {
            return (min, max);
        }

        public int GetCurrent()
        {
            return current;
        }

        public int Current { get { return current; } }

        public void Increment()
        {
            current++;
            if (current > max)
                current = min;
        }



        public override string ToString()
        {
            return $"[{min}; {max}] -> {current}";
        }

    }
}
