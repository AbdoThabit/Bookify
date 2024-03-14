using Bookify.Models;
using Bookify.ViewModel;

namespace Bookify.RoomRepositary
{
    public interface IRoomRepo
    {
        public List<Room> getAllRooms();
        public  List<RoomType> getAllRoomsTypes();
        public List<Room> getAllAvalibleRooms();
        public Room Add(RoomVM model);
        public Room delete(Room room);
        public Room Update(Room room);
    }
}
