using Microsoft.AspNetCore.Identity;

namespace MBL.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            ReadBooks = new HashSet<Book>();
            ToReadBooks = new HashSet<Book>();
        }
        public virtual ICollection<Book> ReadBooks { get; set; }

        
        public virtual ICollection<Book> ToReadBooks { get; set; }
    }
}
