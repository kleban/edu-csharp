using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDemo.Models
{    
    public abstract class Vehicle
    {
        protected string brand;
        protected int speed;

        public Vehicle()
        {
            brand = "Unknown";
            speed = 0;
        }

        public Vehicle(string brand, int speed = 0)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public abstract void Move();

        public string Brand 
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
