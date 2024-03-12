using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    public class CustmerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
