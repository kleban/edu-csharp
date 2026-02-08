using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Many2Many_Seed.Core.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string? Email { get; set; }

        [ForeignKey("PositionId")]
        public Position Position { get; set; }
        public int PositionId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
