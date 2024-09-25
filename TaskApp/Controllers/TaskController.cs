using Microsoft.AspNetCore.Mvc;
using TaskApp.Models;

namespace TaskApp.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MyTask myTask)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) 
        { 
            return View();
        }

        public IActionResult Delete(int id) 
        { 
            return RedirectToAction("Index");
        }
    }
}
