using System.ComponentModel.DataAnnotations;

namespace Bookify.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public ICollection<Staff> Staff { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
