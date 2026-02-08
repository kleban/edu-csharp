using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many2ManyPlusSelfRef.Entities
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public Category? Parent { get; set; }
        public ICollection<Category> SubCategories { get; set; } = new List<Category>();
        public ICollection<Clothing> Clos { get; set; }
    }
}
