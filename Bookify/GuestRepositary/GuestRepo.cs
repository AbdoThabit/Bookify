using Bookify.Models;
using Bookify.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bookify.GuestRepositary
{
    public class GuestRepo : IGuestRepo
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly HotelDbContext context;

        public GuestRepo(UserManager<ApplicationUser> userManager , HotelDbContext _context)
        {
            this.userManager = userManager;
            context = _context;
        }
        public async Task<List<ApplicationUser>> GetAllCustomers()
        {
            var usersInCustomerRole = await userManager.GetUsersInRoleAsync("CUSTOMER");
            return usersInCustomerRole.ToList();
        }
        public void addRole()
        {
            throw new NotImplementedException();
        }

        public void addUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        

        public void removeRole()
        {
            throw new NotImplementedException();
        }

        public void removeUser(string userId)
        {
            throw new NotImplementedException();
        }

        public void updateuser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
