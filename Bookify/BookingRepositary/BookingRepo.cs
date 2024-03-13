using Bookify.Models;
using Bookify.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Bookify.BookingRepositary
{
    public class BookingRepo :IBookingRepo
    {
        public BookingRepo(HotelDbContext _context)
        {
            Context = _context;
        }

        public HotelDbContext Context { get; }

        public List<Booking> GetAllBookings()
        {
            return Context.Bookings.ToList();
        }
        public Booking AddBooking(BookingVM model)
        {
            Booking booking = new Booking()
            {
                CheckInDate = model.CheckInDate,
                 CheckOutDate = model.CheckOutDate,
                TotalPrice = model.TotalPrice
            };
            Context.Bookings.Add(booking);
            Context.SaveChanges();
            return booking;
        }
        public Booking DeleteBooking(int id)
        {
            var booking = Context.Bookings.Find(id);
            Context.Bookings.Remove(booking);
            Context.SaveChanges();
            return booking;
        }


    }

  
}
