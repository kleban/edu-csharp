using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoApp
{
    public abstract class Transport
    {
        protected string model;
        public Transport(string model)
        {
            this.model = model;
        }
    }
}
