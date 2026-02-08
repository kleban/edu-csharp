using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public abstract class PrintedEntity
    {
        public string Title { get; set; }
        public Publisher Publisher { get; set; }
    }
}
