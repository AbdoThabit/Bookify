using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookify.Models
{

    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Room")]
        public int RoomNum { get; set; }

        [Required(ErrorMessage = "Check-in Date is required")]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "Check-out Date is required")]
        public DateTime CheckOutDate { get; set; }

        public decimal TotalPrice { get; set; }

        public Custmer custmer { get; set; }
        public Room Room { get; set; }
    }
}
