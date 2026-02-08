using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class Session
    {
        public Movie Movie { get; set; }
        public string Hall { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime 
        { 
            get { return StartTime.AddMinutes(Movie.Duration); }
        }
        public override string ToString()
        {
            return $"[{StartTime.ToString("HH:mm")}-{EndTime.ToString("HH:mm")}] {Hall} - {Movie}";
        }
    }
}
