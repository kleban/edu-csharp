using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Domain.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public int? Age { get; set; }
        public double FinalWorth { get; set; }
        public Category Category { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public Country? Country { get; set; }
        [ForeignKey(nameof(Country))]
        public int? CountryId { get; set; }

        public override string ToString()
        {
            var country = Country != null ? $"({Country.Title})" : "-";
            return $"{Rank}. {Name} - ${FinalWorth} -  {Country} / {Category}";
        }
    }
}
