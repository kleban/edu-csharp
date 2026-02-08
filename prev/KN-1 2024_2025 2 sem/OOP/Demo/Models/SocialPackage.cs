using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class SocialPackage
    {
        private double sum;
        private double bonus;
        public SocialPackage(double sum, double bonus)
        {
            this.sum = sum;
            this.bonus = bonus;
        }
        public override string ToString()
        {
            return $"${sum}, bonus: ${bonus}";
        }
    }
}
