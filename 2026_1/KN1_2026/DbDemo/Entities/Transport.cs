using System;
using System.Collections.Generic;
using System.Text;

namespace DbDemo.Entities
{
    public class Transport
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public double MaxSpeed { get; set; }
        public Person Owner { get; set; }
    }
}
