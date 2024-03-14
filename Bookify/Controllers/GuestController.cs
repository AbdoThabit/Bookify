using Bookify.GuestRepositary;
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
        public IGuestRepo GuestRepo { get; }
        GuestController(IGuestRepo guestRepo)
        {
            GuestRepo = guestRepo;
        }

       

        [Authorize(Roles = "Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
