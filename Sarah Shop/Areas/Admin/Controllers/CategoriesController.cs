using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sarah_Shop.Data;
using Sarah_Shop.Models;

namespace Sarah_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {

        ApplicationDbContext Context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = Context.Categories.ToList();
            return View("AllCategories", categories);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Store(Category Req)
        {
            if (ModelState.IsValid)
            {
                Context.Categories.Add(Req);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(nameof(Create), Req);
          
        }


        public IActionResult Edit(int id)
        {
            var category = Context.Categories.Find(id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost]
        public IActionResult Update(Category request, int id)
        {
            if (!ModelState.IsValid)
                return View("Edit", request);

            var category = Context.Categories.Find(id);
            if (category == null)
                return NotFound();

            category.Name = request.Name;
            Context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }




        public IActionResult Delete(int Id)
        {
            var category = Context.Categories.Find(Id);
            Context.Categories.Remove(category);
            Context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }



    }
}
