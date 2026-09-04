using OnlineOffline.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOffline.DataParser
{
    public class LearningCsvItem
    {
        public string Subject { get; set; }
        public string Learning_Mode { get; set; }
        public double Study_Hours { get; set; }
        public int Retention_Score { get; set; }
        public int Focus_Level { get; set; }
        public int Exam_Score { get; set; }
    }
}
