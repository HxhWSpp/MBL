using System.Reflection.Metadata.Ecma335;

namespace MBL.Data.Entities
{
    public class Book : BaseEntity
    {
        public string Author { get; set; }
        public string imageLink { get; set; }
        public string Language { get; set; }       
        public string Link { get; set; }
        public string Pages { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


    }
}
