using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    public class ResrvationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
