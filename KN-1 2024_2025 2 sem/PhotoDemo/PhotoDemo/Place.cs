using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    public class Place
    {
        public string? Title { get; set; }
        public string? ImagePath { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
