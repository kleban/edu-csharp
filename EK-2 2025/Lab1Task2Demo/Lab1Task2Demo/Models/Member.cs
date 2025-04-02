using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Task2Demo.Models
{
    public class Member : Person
    {
        public DateTime DateJoined { get; set; }
        public Membership Membership { get; set; }
    }
}
