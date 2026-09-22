using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOffline.Core.Models
{
    public class LearningResult
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public LearningMode Mode { get; set; }
        public double StudyHours { get; set; }
        public int RetentionScore { get; set; }
        public int FocusLevel { get; set; }
        public int ExamScore { get; set; }

        public override string ToString()
        {
            return $"{Subject.Name} ({Mode.Name}) - {ExamScore}";
        }
    }
}
