using Bookify.Models;
using Bookify.RoomRepositary;
using System.ComponentModel.DataAnnotations;

namespace Bookify.ViewModel
{
    public class RoomVM
    {
        private  IRoomRepo roomrepo;
        public RoomVM(IRoomRepo roomrepo)
        {
            this.roomrepo = roomrepo;
            this.types = roomrepo.getAllRoomsTypes();
        }

        [Required]
        [RegularExpression("^(free|reserved)$", ErrorMessage = "Status can only be 'free' or 'reserved'")]
        public string Status { get; set; }
        [Required]
        public int RoomTypeId { get; set; }

        public virtual List<RoomType> types { get; set; } = new List<RoomType>();

    }
}
