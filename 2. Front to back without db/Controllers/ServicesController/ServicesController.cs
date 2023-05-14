using Microsoft.AspNetCore.Mvc;

namespace _2._Front_to_back_without_db.Controllers.ServicesController
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
