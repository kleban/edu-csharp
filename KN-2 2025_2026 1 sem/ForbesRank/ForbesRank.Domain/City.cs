using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForbesRank.Domain
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public Country? Country { get; set; }

        public virtual ICollection<Person>? People { get; set; } = new List<Person>();
    }
}
