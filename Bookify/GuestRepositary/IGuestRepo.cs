using Bookify.Models;

namespace Bookify.GuestRepositary
{
    public interface IGuestRepo
    {
        public  Task<List<ApplicationUser>> GetAllCustomers();
        public Task<ApplicationUser> GetUserByIdAsync(string userId);
        
        public void addRole();
        public Task<ApplicationUser> removeUser(string userId);
        public void removeRole();
        public void addUser(ApplicationUser user);
        
        public void updateuser(ApplicationUser user);
    }
}
