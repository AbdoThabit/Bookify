using Bookify.GuestRepositary;
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
        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await userManager.FindByIdAsync(userId);
        }
        public async Task<IActionResult> AddRoleToUser(string userId, string roleId)
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

        public async Task<ApplicationUser> removeUser(string userId)
        {
            var user = await GetUserByIdAsync(userId);
            if (user != null)
            {
                await userManager.DeleteAsync(user);
                return user;
            }

            
            return null;
        }

        public void updateuser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
