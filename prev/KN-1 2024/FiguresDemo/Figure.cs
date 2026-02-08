using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresDemo
{
    public abstract class Figure
    {
        protected Figure()
        {
            Console.WriteLine(typeof(Figure));
        }
        public abstract double P();
        public abstract double S();
    }
}
