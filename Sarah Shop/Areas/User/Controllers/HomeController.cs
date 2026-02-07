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
        public IActionResult AllProducts()
        {
            var products = context.Products.ToList();
            return View(products);
        }





    }
}
