using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Task2Demo.Models
{
    public abstract class Workout
    {
        public string Title { get; set; }
        public Trainer Trainer { get; set; }
        public DateTime Date { get; set; }
        public Equipment[] Equipment { get; set; }

        public override string ToString()
        {
            return $"[{Date.ToString("dd/MM/yyyy HH:mm")}] {Title}, ({Trainer.Name}) - {Equipment.Length}";
        }
    }
}
