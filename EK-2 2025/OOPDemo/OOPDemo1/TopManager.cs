using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo1
{
    public class TopManager : Manager
    {
        private double share = 0;
        public TopManager() : base()
        {
        }
        public TopManager(string name, int age, double salary, int n, double share)
            : base(name, age, salary, n)
        {
            this.share = share;
        }
        public override string ToString()
        {
            return $"TopManager: {name}: {age} years old, ${salary} ---> {numberOfSubordinates} +++++ share: {share*100}%";
        }        
    }
}
