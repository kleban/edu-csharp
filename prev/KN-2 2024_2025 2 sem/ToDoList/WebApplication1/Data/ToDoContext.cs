using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
