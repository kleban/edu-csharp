using System;
using System.Collections.Generic;
using System.Text;

namespace StdPerfomance.Core.Entities
{
    public class StressLevel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<StudentScore> StudentScores { get; set; }
    }

}
