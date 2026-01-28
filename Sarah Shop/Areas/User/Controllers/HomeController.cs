using Microsoft.AspNetCore.Mvc;

namespace Sarah_Shop.Areas.User.Controllers
{
    [Area("User")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
