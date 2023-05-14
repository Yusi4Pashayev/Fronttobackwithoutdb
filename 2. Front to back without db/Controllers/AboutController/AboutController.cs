using Microsoft.AspNetCore.Mvc;

namespace _2._Front_to_back_without_db.Controllers.AboutController
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
