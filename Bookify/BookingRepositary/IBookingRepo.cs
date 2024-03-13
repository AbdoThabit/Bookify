using Bookify.Models;
using Bookify.ViewModel;

namespace Bookify.BookingRepositary
{
    public interface IBookingRepo
    {
       public List<Booking> GetAllBookings();
       public Booking AddBooking(BookingVM model);
     
       public Booking DeleteBooking(int id);
     
    }
}
