using Bookify.Models;
using Bookify.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bookify.Controllers
{
    public class GuestController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        GuestController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        [Authorize(Roles = "Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
