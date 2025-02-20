using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [MinLength(10)]
        [Required]
        public string Description { get; set; }

        public virtual ICollection<TodoItem> Tasks { get; set; } = new HashSet<TodoItem>();
    }
}
