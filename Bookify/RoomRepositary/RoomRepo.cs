using Bookify.Models;
using Bookify.ViewModel;

namespace Bookify.RoomRepositary
{
    public class RoomRepo : IRoomRepo
    {
        public RoomRepo(HotelDbContext _context)
        {
            Context = _context;
        }

        public HotelDbContext Context { get; }
        public Room Add(RoomVM model)
        {
            Room room = new Room()
            {
                RoomTypeId = model.RoomTypeId,
                Status  = model.Status,

            };
            Context.Rooms.Add(room);
            Context.SaveChanges();
            return room;
        }
        public Room Update(Room room)
        {
            throw new NotImplementedException();
        }

        public Room delete(Room room)
        {
            Context.Remove(room);
            Context.SaveChanges();
            return room;
        }

        public List<Room> getAllRooms()
        {
            return Context.Rooms.ToList();
        }

        public  List<RoomType> getAllRoomsTypes()
        {
            return Context.RoomTypes.ToList();
        }

       
    }
}
