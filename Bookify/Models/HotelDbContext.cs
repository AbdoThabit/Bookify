using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Bookify.Models
{
    public class HotelDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Room> Rooms { get; set;}
        public virtual DbSet<RoomType> RoomTypes { get; set;}
        public virtual DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-68GQKG3;Initial Catalog=Hotel;Integrated Security=True;TrustServerCertificate=True");
        }

       
    }
}
