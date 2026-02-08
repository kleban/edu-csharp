using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Task2Demo.Models
{
    public class Schedule
    {
        public Schedule()
        {
            Workouts = new Workout[0];
        }

        public Workout[] Workouts { get; set; }

        public void AddWorkout(Workout workout)
        {
            var workouts = new List<Workout>(Workouts);
            workouts.Add(workout);
            Workouts = workouts.ToArray();
        }

    }
}
