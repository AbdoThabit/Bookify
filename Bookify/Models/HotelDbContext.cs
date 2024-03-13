using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bookify.ViewModel;


namespace Bookify.Models
{
    public class HotelDbContext : IdentityDbContext<ApplicationUser>
    {
       
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }

        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Bookify.ViewModel.LoginVM> LoginVM { get; set; } = default!;

    }

    }

