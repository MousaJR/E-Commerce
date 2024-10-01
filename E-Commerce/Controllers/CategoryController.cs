using E_Commerce.Date;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext dbContext=new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories=dbContext.Categories.ToList();

            return View(categories);
        }

        public IActionResult CreateNew()
        {

            return View();
        }
    }
}
