using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForbesRank.Core.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Country? Country { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
    }
}
