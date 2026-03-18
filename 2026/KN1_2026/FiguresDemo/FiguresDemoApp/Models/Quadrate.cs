using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemoApp.Models
{
    public class Quadrate : Rect
    {
        public Quadrate(double a)
            : base(a,a)
        {            
        }

        public override double P()
        {
            return 4*a;
        }

        public override double S()
        {
            return a*a;
        }
    }
}
