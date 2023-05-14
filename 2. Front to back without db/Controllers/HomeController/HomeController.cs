using Microsoft.AspNetCore.Mvc;

namespace _2._Front_to_back_without_db.Controllers.HomeController
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
