using System;
using System.Collections.Generic;
using System.Text;

namespace StdPerfomance.Core.Entities
{
   public class StudentScore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudyHours { get; set; }
        public int SleepHours { get; set; }
        public int SocialMediaHours { get; set; }
        public int ExamScore { get; set; }
        public StressLevel StressLevel { get; set; }

        public override string ToString()
        {
            return $"{Name} - {ExamScore} ({StressLevel.Title})";
        }
    }
}
