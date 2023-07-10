using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VegitableShop.Models;

namespace VegitableShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly dbVegitableShopContext _context;

        public ProductController(dbVegitableShopContext dbVegitableShopContext)
        {
            this._context = dbVegitableShopContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products.Include(x => x.Cat).FirstOrDefault(i => i.ProductId == id);

            if (product == null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
