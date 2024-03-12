using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookify.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("staff")]
        public int? id { get; set; }

        public Staff? staff { get; set; }

     
    }
}
