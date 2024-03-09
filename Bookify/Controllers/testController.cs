using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return Content("hellow from abdo");
        }
    }
}
