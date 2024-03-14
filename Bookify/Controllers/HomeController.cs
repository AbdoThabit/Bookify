using Bookify.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    [Authorize(Roles = "Admin")]

    public class HomeController : Controller
    {
        private readonly HotelDbContext _context;

        public HomeController(HotelDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.RoomsCount = _context.Rooms.Count();
            ViewBag.RoomsTypeCount = _context.RoomTypes.Count();
            ViewBag.ReservationsCount = _context.Bookings.Count();
            ViewBag.UsersCount = _context.Users.Count();
            return View();
        }
    }
}
