using Microsoft.AspNetCore.Mvc;

namespace VegitableShop.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
