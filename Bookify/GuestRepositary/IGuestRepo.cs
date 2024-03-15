using Bookify.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.GuestRepositary
{
    public interface IGuestRepo
    {
        public  Task<List<ApplicationUser>> GetAllCustomers();
        public Task<ApplicationUser> GetUserByIdAsync(string userId);

        public  Task<IActionResult> AddRoleToUser(string userId, string roleId);
        public Task<ApplicationUser> removeUser(string userId);
        public void removeRole();
        public void addUser(ApplicationUser user);
        
        public void updateuser(ApplicationUser user);
    }
}
