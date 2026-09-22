using StdPerfomance.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StdPerfomance.Parser.Models
{
    public class StudentScoreReadItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int study_hours { get; set; }
        public int sleep_hours { get; set; }
        public int social_media_hours { get; set; }
        public int exam_score { get; set; }
        public string stress_level { get; set; }
    }
}
