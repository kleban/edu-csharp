using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace FrbsApp.Core.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public virtual ICollection<Person>? People { get; set; } = new List<Person>();
        public override string ToString()
        {
            return Name;
        }
    }
}
