using System.ComponentModel.DataAnnotations;

namespace Bookify.ViewModel
{
    public class BookingVM
    {
        public int BookingId { get; set; }


        [Required(ErrorMessage = "Check-in Date is required")]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "Check-out Date is required")]
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
