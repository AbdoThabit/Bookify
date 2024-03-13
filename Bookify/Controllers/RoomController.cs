using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
