using Bookify.Models;
using Bookify.RoomRepositary;
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
        
    }
}
