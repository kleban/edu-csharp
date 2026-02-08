using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ToDoList.Data;
using ToDoList.Models;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ToDoContext _context;

        public ProjectController(ToDoContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? view)
        {
            var projects = _context.Projects.Include(x => x.Tasks).ToList();

            if (!string.IsNullOrEmpty(view) && view == "a")
                return View("Index2", projects);
            return View(projects);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
