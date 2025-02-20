using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Index(int id)
        {
            ViewData["project_id"] = id;
            ViewBag.ProjectId = id;            
            var todos = _context.TodoItems.Where(x=> x.ProjectId == id).ToList();
            return View(todos);
        }

        public IActionResult Edit(int id)
        {
            var task = _context.TodoItems.First(x=> x.Id == id);
            var selectedProject = _context.Projects.FirstOrDefault(x => x.Id == task.ProjectId);
            ViewBag.Projects = new SelectList(_context.Projects.ToList(), "Id", "Name", selectedProject);
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(TodoItem todo)
        {
            if (ModelState.IsValid)
            {
                _context.TodoItems.Update(todo);
                _context.SaveChanges();
                return RedirectToAction("Index", new { id = todo.ProjectId });
            }
            return View(todo);
        }

        public IActionResult Create(int? projectId)
        {            
            var selectedProject = _context.Projects.FirstOrDefault(x=> x.Id == projectId);
            ViewBag.Projects = new SelectList(_context.Projects.ToList(), "Id", "Name", selectedProject);
            return View(new TodoItem());
        }

        [HttpPost]
        public IActionResult Create(TodoItem todo)
        {
            if (ModelState.IsValid)
            {
                _context.TodoItems.Add(todo);
                _context.SaveChanges();
                return RedirectToAction("Index", new { id = todo.ProjectId });
            }
            //ViewBag.Projects = new SelectList(_context.Projects.ToList(), "Id", "Name", todo.ProjectId);

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
