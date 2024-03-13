using Bookify.Models;
using Bookify.BookingRepositary;
using Microsoft.AspNetCore.Mvc;
using Bookify.ViewModel;


namespace Bookify.Controllers
{
    public class BookingController : Controller
    {
        public BookingController(IBookingRepo BookingRepo)
        {
             _bookingRepository =BookingRepo;
        }

        public IBookingRepo _bookingRepository { get; }

        public ActionResult Index()
        {
            var bookings = _bookingRepository.GetAllBookings();
            return View(bookings);
        }

     
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(BookingVM model)
        {
            
                _bookingRepository.AddBooking(model);

                return RedirectToAction("Index");
           
            // return View(booking);
        }

    }

        
       
    }

