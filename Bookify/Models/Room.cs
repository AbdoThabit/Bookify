using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookify.Models
{
    public class Room
    {

        [Key]
    public int RoomNum { get; set; }

    [ForeignKey("Hotel")]
    public int HotelId { get; set; }

    public string Status { get; set; }

    [ForeignKey("RoomType")]
    public int RoomTypeId { get; set; }

    public Hotel Hotel { get; set; }
    public RoomType RoomType { get; set; }
    public ICollection<Booking> Bookings { get; set; }

    }
}

