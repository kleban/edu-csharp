using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForbesRank.Core.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public double Worth { get; set; } 
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Country? Country { get; set; }
        [ForeignKey(nameof(Country))]
        public int? CountryId { get; set; }

        public override string ToString()
        {
            return "";
        }
    }
}
