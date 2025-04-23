using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresDemo.Models
{
    public class Square : Rectangle
    {
        public Square(double a)
            : base(a, a)
        {
        }
        public override double GetS()
        {
            return a * a;
        }
        public override double GetP()
        {
            return a * 4;
        }
    }
}
