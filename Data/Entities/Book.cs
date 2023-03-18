using System.Reflection.Metadata.Ecma335;

namespace MBL.Data.Entities
{
    public class Book : BaseEntity
    {
        public Book()
        {
            ReadBooks = new HashSet<UserReadBook>();
            WantedBooks = new HashSet<UserWantedBook>();
        }
        public virtual ICollection<UserReadBook> ReadBooks { get; set; }


        public virtual ICollection<UserWantedBook> WantedBooks { get; set; }
    
        public string Author { get; set; }
        public string ImageLink { get; set; }
        public string Language { get; set; }
        public string Link { get; set; }
        public string Pages { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
