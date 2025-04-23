using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresDemo.Models
{
    public abstract class Figure
    {
        public abstract double GetP();
        public abstract double GetS();

        public override string ToString()
        {
            return $"S: {GetS()}, P: {GetP()}";
        }
    }
}
