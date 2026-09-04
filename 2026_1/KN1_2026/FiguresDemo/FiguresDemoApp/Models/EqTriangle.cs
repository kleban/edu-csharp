using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemoApp.Models
{
    public class EqTriangle : IsoscelesTriangle
    {
        public EqTriangle(double a) 
            : base(a,a)
        {
            
        }

        public override double P()
        {
            return a * 3;
        }
    }
}
