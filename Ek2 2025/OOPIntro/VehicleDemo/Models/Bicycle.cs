using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDemo.Models
{
    public class Bicycle : Vehicle
    {
        private bool hasBell;
        public Bicycle(string brand, int speed, bool hasbell) 
            : base(brand, speed)
        {
            hasBell = hasbell;
        }

        public Bicycle(string brand, int speed) :
            this(brand, speed, false)
        { }

        public override void Move()
        {
            string message = hasBell ? "ring-ring-ring-ring" : "silence";
            Console.WriteLine($"My bicycle {brand} moving {speed} km/h! {message}.");
        }
        public bool HasBell
        {
            get { return hasBell; }
            set { hasBell = value; }
        }
    }
}
