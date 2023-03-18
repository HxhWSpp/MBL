using Microsoft.AspNetCore.Identity;

namespace MBL.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            ReadBooks = new HashSet<UserReadBook>();
            WantedBooks = new HashSet<UserWantedBook>();
        }
        public virtual ICollection<UserReadBook> ReadBooks { get; set; }

        
        public virtual ICollection<UserWantedBook> WantedBooks { get; set; }
    }
}
