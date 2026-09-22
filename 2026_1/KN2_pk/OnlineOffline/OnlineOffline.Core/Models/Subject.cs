using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOffline.Core.Models
{
   public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<LearningResult> LearningResults { get; set; }
    }
}
