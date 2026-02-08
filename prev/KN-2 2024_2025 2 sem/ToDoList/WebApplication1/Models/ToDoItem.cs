using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Task { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime StatusDate { get; set; } = DateTime.Now;

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }

        public Project? Project { get; set; }
    }
}
