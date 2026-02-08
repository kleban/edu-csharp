using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApp
{
    public class Counter
    {
        private int current;
        private int min;
        private int max;

        public Counter()
        {
            min = 1;
            current = min;
            max = 10;
        }

        public Counter(int min, int max)
        {
            if (min > max)
                (min, max) = (max, min);

            this.min = min;
            current = min;
            this.max = max;
        }

        public int Current { get { return current; } }

        public void Increment()
        {
            if (current < max)
                current++;
            else
                current = min;
        }
    }
}
