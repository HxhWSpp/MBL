using MBL.Data.Entities;

namespace MBL.Models
{
    public class BookModel : BaseEntity
    {
        public BookModel()
        {
            ReadBooks = new HashSet<UserReadBook>();
            WantedBooks = new HashSet<UserWantedBook>();
        }
        public virtual ICollection<UserReadBook> ReadBooks { get; set; }


        public virtual ICollection<UserWantedBook> WantedBooks { get; set; }

        public string Author { get; set; }
        public IFormFile Image { get; set; }
        public string Language { get; set; }
        public string Link { get; set; }
        public string Pages { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
    }
}
