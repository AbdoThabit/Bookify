using Bookify.Models;
using Bookify.RoomRepositary;
using Bookify.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    public class RoomController : Controller
    {
        public RoomController(IRoomRepo roomRepo)
        {
            RoomRepo = roomRepo;
        }

        public IRoomRepo RoomRepo { get; }

        public IActionResult Index()
        {
            List<Room> roomList = RoomRepo.getAllRooms();
            return View(roomList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.roomTypes = RoomRepo.getAllRoomsTypes();
            return View();
        }
        [HttpPost]
        public IActionResult Create(RoomVM model)
        {
            RoomRepo.Add(model);

            return RedirectToAction("index","Room");
        }

    }
}
