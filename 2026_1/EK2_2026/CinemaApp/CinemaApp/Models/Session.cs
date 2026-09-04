using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Models
{
    public class Session
    {
        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
