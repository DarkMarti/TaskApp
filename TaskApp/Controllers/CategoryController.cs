using Microsoft.AspNetCore.Mvc;
using TaskApp.DataBaseContext;
using TaskApp.Models;

namespace TaskApp.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext _context;        

        public CategoryController(ApplicationDbContext applicationDbContext) {            
            _context = applicationDbContext;
        }

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
        public IActionResult Create(CategoryDTO categoryDto)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.Name = categoryDto.Name;
                category.Abbreviation = categoryDto.Abbreviation;
                category.Color = categoryDto.Color;

                _context.Add(category);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(categoryDto);            
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
