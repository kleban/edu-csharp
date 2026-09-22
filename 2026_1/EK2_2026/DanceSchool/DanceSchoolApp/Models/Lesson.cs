using System;
using System.Collections.Generic;
using System.Text;

namespace DanceSchoolApp.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Group Group { get; set; }

        public override string ToString()
        {
            var time = (EndTime - StartTime).TotalMinutes;
            return $"{Group.Name} ({StartTime.ToString("dd.MM.yy")}, {time} хв.)";
        }
    }
}
