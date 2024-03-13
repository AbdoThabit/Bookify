using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    [Authorize(Roles = "Admin")]

    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
