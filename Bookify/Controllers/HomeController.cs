using Bookify.GuestRepositary;
using Bookify.Models;
using Bookify.UserRepositary;
using Bookify.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    [Authorize(Roles = "Admin")]

    public class HomeController : Controller
    {
        private readonly HotelDbContext _context;
        private readonly IUserRepo userRepo;

        public HomeController(HotelDbContext context,IUserRepo userRepo)
        {
            _context = context;
            this.userRepo = userRepo;
        }

        public IActionResult Index()
        {
            ViewBag.RoomsCount = _context.Rooms.Count();
            ViewBag.RoomsTypeCount = _context.RoomTypes.Count();
            ViewBag.ReservationsCount = _context.Bookings.Count();
            ViewBag.UsersCount = _context.Users.Count();
            return View();
        }
        [HttpGet]
        public IActionResult AddUser()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser(UserVM model)
        {
            if (ModelState.IsValid) 
            {
                userRepo.AddUser(model);
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> AllUsers()
        {
            List<ApplicationUser> Users = await userRepo.GetAllUser();
            return View(Users);
        }
    }
}
