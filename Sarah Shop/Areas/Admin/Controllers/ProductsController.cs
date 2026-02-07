using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sarah_Shop.Data;
using Sarah_Shop.Models;

namespace Sarah_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductsController : Controller
    {

        ApplicationDbContext Context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var products = Context.Products.Include(p => p.category).ToList();
            return View("AllProducts" , products);
        }
        public IActionResult Create() 
        {
            //ViewData["categories"] = Context.Categories.ToList();
            ViewBag.Categories = Context.Categories.ToList();
            return View();
        }

        public IActionResult Store(Product request , IFormFile Image)
        {
            if (Image != null && Image.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString();
                fileName += Path.GetExtension(Image.FileName);

                var filePath = Path.Combine(Directory.GetCurrentDirectory() ,@"wwwroot\images" , fileName);

                using (var stream = System.IO.File.Create(filePath)) 
                {
                    Image.CopyTo(stream);
                }

                request.Image = fileName;
                Context.Products.Add(request);
                Context.SaveChanges();
                return RedirectToAction("Index");
                
            }
            return Content("ok");
            
        }
    }
}
