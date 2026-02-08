using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public abstract class Transport
    {
        protected string model;

        protected Transport(string model)
        {
            this.model = model;
        }
    }
}
