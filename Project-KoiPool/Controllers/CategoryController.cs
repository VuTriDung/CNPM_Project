using Microsoft.AspNetCore.Mvc;

namespace Project_KoiPool.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
