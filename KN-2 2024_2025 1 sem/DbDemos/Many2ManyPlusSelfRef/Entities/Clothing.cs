using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many2ManyPlusSelfRef.Entities
{
    public class Clothing
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }
        public ICollection<Size> Sizes { get; set; } = new List<Size>();
        public Category? Category { get; set; }
    }
}
