using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfrencePlanner.Models
{
    public class Report
    {
        public string Title { get; set; }
        public Speaker? Speaker { get; set; } = null;
        public DateTime DateAndTime { get; set; }
        public int DurationMin { get; set; } // in minutes
    }
}
