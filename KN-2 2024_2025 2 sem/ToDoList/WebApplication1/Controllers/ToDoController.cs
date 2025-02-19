using Microsoft.AspNetCore.Mvc;
using System;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoContext _context;

        public ToDoController(ToDoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var todos = _context.TodoItems.ToList();
            return View(todos);
        }

        [HttpPost]
        public IActionResult Create(TodoItem todo)
        {
            if (ModelState.IsValid)
            {
                _context.TodoItems.Add(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }

        [HttpPost]
        public IActionResult ToggleComplete(int id)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo != null)
            {
                todo.IsCompleted = !todo.IsCompleted;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo != null)
            {
                _context.TodoItems.Remove(todo);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
