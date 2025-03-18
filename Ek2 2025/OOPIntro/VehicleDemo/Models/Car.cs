using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDemo.Models
{    
    public class Car : Vehicle
    {
        private FuelType fuelType;
        public Car(string brand, int speed, FuelType fuelType)
            : base(brand, speed)
        {
            this.fuelType = fuelType;
        }

        public override void Move()
        {
            Console.WriteLine($"My car {brand}/{fuelType} moving {speed} km/h");
        }

        public FuelType FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
    }
}
