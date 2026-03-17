using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesApp.ConsoleApp.Models
{
    public class Workout
    {
        private string title;
        private int time;

        public Workout(string title, int time)
        {
            this.title = title;
            this.time = time;
        }
    }
}
