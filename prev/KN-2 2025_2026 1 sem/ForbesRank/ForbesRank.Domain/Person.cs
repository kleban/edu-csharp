using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbesRank.Domain
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public int? Age { get; set; }
        public decimal FinalWorth { get; set; }
        public Category? Category { get; set; }
      //?????  public Country? Country { get; set; }
        public City? City { get; set; }
        public DateTime? BirthDate { get; set; }

        public override string ToString()
        {
            return $"{Rank}. {Name} - {FinalWorth}B$, ({(Category is not null? Category.Name: "-")}), ({(City is not null ? (City.Country is null ? City.Name : $"{City.Name}, {City.Country.Name}"  ) : "no city")})";
        }
    }
}
