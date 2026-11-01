using System;
using System.Collections.Generic;
using System.Text;

namespace ForbesRank.Core.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; } = new List<City>();
    }
}
