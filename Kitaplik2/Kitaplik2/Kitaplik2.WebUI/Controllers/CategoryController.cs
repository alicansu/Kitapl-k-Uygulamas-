using Microsoft.AspNetCore.Mvc;

namespace Kitaplik2.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
