using Microsoft.AspNetCore.Mvc;
using Sarah_Shop.Data;

namespace Sarah_Shop.Areas.User.Controllers
{
    [Area("User")]

    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();

            return View(categories);
        }

        [HttpGet]
        public IActionResult AllProducts()
        {
            var products = context.Products.ToList();
            return View(products);
        }
        public IActionResult ProductsByCategory(int categoryId)
        {
            var products = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            return View(products);

        }





    }
}
