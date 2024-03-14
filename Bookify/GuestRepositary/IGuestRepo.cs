using Bookify.Models;

namespace Bookify.GuestRepositary
{
    public interface IGuestRepo
    {
        public  Task<List<ApplicationUser>> GetAllCustomers();
        public void addRole();
        public void removeUser(string userId);
        public void removeRole();
        public void addUser(ApplicationUser user);
        
        public void updateuser(ApplicationUser user);
    }
}
