using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOffline.Core.Models
{
    public class LearningMode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<LearningResult> LearningResults { get; set; }
    }
}
