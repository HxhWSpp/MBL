using System.Reflection.Metadata.Ecma335;

namespace MBL.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string imageLink { get; set; }
        public string Language { get; set; }       
        public string Link { get; set; }
        public string Pages { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int BookListId { get; set; }
    }
}
