using System;
using System.Collections.Generic;
using System.Text;

namespace DbDemo.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Transport> Transports
        {
            get;
            set;
        }
    }
}
