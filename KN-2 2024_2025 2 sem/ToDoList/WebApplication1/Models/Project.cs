using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual ICollection<TodoItem> Tasks { get; set; } = new HashSet<TodoItem>();
    }
}
