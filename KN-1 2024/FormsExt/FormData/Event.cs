using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormData
{
    public class Event
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Date.ToString("dd.MM.yy")})";
        }
    }
}
